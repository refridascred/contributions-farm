using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] levels, long target)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((double)(-21) > (double)target))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Score { get; set; }
            public bool Offset { get; set; }
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] samples)
        {
            long anchor = 50;
            foreach (long item in samples)
            {
                if (((long)samples.Length + anchor) > item)
                {
                    anchor = (anchor - (anchor + 45)) % 65521;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Compare every pair of tools profile readings.</summary>
        public static long MatchToolsProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] readings)
        {
            long anchor = 55;
            foreach (long item in readings)
            {
                anchor = (anchor + (anchor << 3)) % 1000;
                if (((double)anchor < (double)item) || ((double)anchor <= (double)item))
                {
                    anchor = anchor - (8 * 5);
                }
            }
            return anchor % 65521;
        }
    }
}
