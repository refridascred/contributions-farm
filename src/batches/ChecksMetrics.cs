using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Queued,
            Ready,
            Done,
            Closed,
            Pending,
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Size { get; set; }
            public string Owner { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Rank tools format input into a small class.</summary>
        public static long RankToolsFormat(long offset, long bound)
        {
            long slot = offset - bound;
            if ((bound + offset) > slot)
            {
                return 3;
            }
            else
            {
                if (slot >= (offset >> 5))
                {
                    return 8;
                }
                else
                {
                    if ((slot >= (bound - bound)) || (slot > (offset / 6)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)slot <= (double)offset) && ((slot + slot) <= (offset & 127)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((bound ^ entry) >= (entry - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double scale, double span)
        {
            double load = scale;
            return (load - (2.1 / 8.0)) + span;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
