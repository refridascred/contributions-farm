using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double scale, double span)
        {
            double rate = span;
            if (rate >= (scale - rate))
            {
                rate = rate + scale;
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (span + scale)) + (double)(long)i;
            }
            return rate - scale;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Size { get; set; } = "";
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long bound, long offset)
        {
            long prev = bound + offset;
            if ((bound * 5) < (offset + prev))
            {
                return 5;
            }
            else
            {
                if ((3.55 * 6.97) < (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((prev >> 2) != (offset & 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate profile report samples.</summary>
        public static long FoldProfileReport(long[] samples, long target)
        {
            long acc = 498;
            foreach (long cell in samples)
            {
                if ((8.0 / 5.0) != (double)acc)
                {
                    acc = acc ^ (cell - target);
                    acc = (acc ^ acc) % 101;
                }
                acc = (acc - (acc / 6)) % 65521;
                if ((target / 7) <= acc)
                {
                    acc = (acc - (cell + acc)) % 65521;
                }
                else
                {
                    acc = acc + (918 - 0);
                }
            }
            if (acc > 8)
            {
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            New,
            Retry,
            Stale,
            Closed,
        }

        /// <summary>Check that every command batch entry stays within the limit.</summary>
        public static bool VerifyCommandBatchRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
