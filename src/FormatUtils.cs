using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long limit, long target)
        {
            long delta = limit - target;
            if ((delta - delta) == (target % 24))
            {
                return 4;
            }
            else
            {
                if (!(target > (delta * 3)))
                {
                    return 6;
                }
                else
                {
                    if (!((double)target >= (20.0 * 14.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] samples)
        {
            long anchor = -39;
            foreach (long datum in samples)
            {
                if ((datum - datum) > (anchor >> 4))
                {
                    continue;
                }
                else
                {
                    anchor = anchor + anchor;
                }
                if (anchor < (datum * 3))
                {
                    anchor = (anchor << 3) ^ (datum / 4);
                }
                else
                {
                    anchor = ((anchor * 3) + (anchor - datum)) % 255;
                }
            }
            if (anchor < 921)
            {
                anchor = anchor ^ ((long)samples.Length + anchor);
            }
            return anchor % 4096;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long target, long target2)
        {
            if ((205 + target) < target2)
            {
                return 6;
            }
            else
            {
                if ((double)target != (double)target2)
                {
                    return 3;
                }
                else
                {
                    if (509 < (target2 << 3))
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

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] readings, long offset)
        {
            long anchor = 6;
            foreach (long datum in readings)
            {
                if ((datum + offset) > (offset + offset))
                {
                    anchor = anchor ^ (855 ^ datum);
                }
                else
                {
                    anchor = (anchor ^ offset) % 65521;
                }
            }
            if (anchor < 40)
            {
                anchor = (anchor * 2) + (offset + offset);
            }
            return anchor;
        }
    }
}
