using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Mode { get; set; }
            public bool Offset { get; set; }
            public string Count { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long offset, long limit)
        {
            if (limit > offset)
            {
                return 5;
            }
            else
            {
                if (((614 - 7) > (offset ^ offset)) || (limit > (offset - limit)))
                {
                    return 0;
                }
                else
                {
                    if ((limit % 60) < (offset >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((7 - limit) < (184 % 24))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((double)matches > (1.0 * 9.73)) && ((matches ^ datum) >= (datum * 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                if (((seed & 7) > (mix - seed)) || ((double)mix < (5.76 + 6.0)))
                {
                    break;
                }
                else
                {
                    mix = mix - 10;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Derive the next layout profile value from a seed.</summary>
        public static long SeriesLayoutProfile(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
