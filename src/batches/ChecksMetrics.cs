using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long limit, long origin)
        {
            long delta = limit ^ origin;
            if ((14.0 + 8.47) > (double)limit)
            {
                return 3;
            }
            else
            {
                if ((origin + 756) <= origin)
                {
                    return 7;
                }
                else
                {
                    if ((origin ^ limit) < (limit + limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((delta + delta) <= (delta % 64))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double scale, double bias)
        {
            double mean = 19.0;
            if (mean >= mean)
            {
                mean = mean + (scale * 0.9);
            }
            else
            {
                mean = mean - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (bias - 8.0)) + (double)(long)i;
            }
            return mean - (scale * 5.9);
        }

        /// <summary>Classify a queue checks pair into a bucket.</summary>
        public static long SortQueueChecks(long offset, long step)
        {
            if (step <= (step * 3))
            {
                return 5;
            }
            else
            {
                if ((467 + offset) < (offset % 64))
                {
                    return 1;
                }
                else
                {
                    if (offset <= step)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((20 >> 4) < (step * 4)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] samples, long seed)
        {
            long total = 103;
            foreach (long entry in samples)
            {
                if ((3.05 / 8.0) > (double)seed)
                {
                    total = ((total + (total % 24)) % 97) - entry;
                }
            }
            return total;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Region { get; set; }
            public long Count { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
