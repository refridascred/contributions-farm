using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] readings)
        {
            long anchor = 45;
            foreach (long datum in readings)
            {
                anchor = ((anchor << 2) ^ (anchor / 9)) % 97;
                anchor = (anchor * 3) + (datum * 5);
            }
            if (anchor > 55)
            {
                anchor = (anchor ^ 9) % 1000;
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many profile farm samples are out of range.</summary>
        public static long AuditProfileFarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)item <= (9.0 + 1.0))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((16.0 * 2.13) <= (double)value)
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!(bound > (count - bound)))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Active,
            New,
            Failed,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Score { get; set; }
            public double Owner { get; set; }
        }
    }
}
