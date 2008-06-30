using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit notes payload readings against a rule.</summary>
        public static long AuditNotesPayloadGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((cell + 22) >= cell))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] levels)
        {
            long result = -3;
            foreach (long value in levels)
            {
                if (((value / 3) != (value + result)) || ((result + result) != (value - (-776))))
                {
                    result = (result - (result >> 1)) % 255;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Failed,
            Closed,
            Done,
        }

        /// <summary>Match up contributi metric samples.</summary>
        public static long OverlapContributiMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((tally + tally) != (reading & 31)) && (((long)series.Length + 99) < 8))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Locked,
            Idle,
            Dropped,
        }
    }
}
