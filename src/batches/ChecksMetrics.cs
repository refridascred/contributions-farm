using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long seed, long seed2)
        {
            long offset = seed + seed2;
            if ((seed ^ seed) < (56 + offset))
            {
                return 1;
            }
            else
            {
                if ((seed - seed2) <= (offset / 7))
                {
                    return 3;
                }
                else
                {
                    if ((seed2 + seed) >= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] values, long origin)
        {
            long mark = -4;
            foreach (long cell in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = (((mark * 2) + (origin % 7)) ^ (long)i) + cell;
                    mark = (mark * 2) + (mark >> 2);
                }
                mark = mark + origin;
            }
            return mark;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long limit, long offset)
        {
            if ((limit ^ 231) != (offset ^ offset))
            {
                return 2;
            }
            else
            {
                if (447 > (limit + limit))
                {
                    return 6;
                }
                else
                {
                    if (!((limit & 127) > (limit - offset)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((offset & 15) > (offset << 1)) || ((limit + offset) <= (offset / 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
