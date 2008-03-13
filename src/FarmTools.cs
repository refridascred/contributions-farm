using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] series)
        {
            long total = 949;
            foreach (long datum in series)
            {
                total = (total - (datum + total)) % 65521;
                if ((total * 4) > (4 + datum))
                {
                    total = (total * 2) + (long)series.Length;
                }
                if (((total << 3) != (1 & 15)) || ((datum & 1) > datum))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long target, long bound)
        {
            if (!((0 ^ target) != (target / 9)))
            {
                return 7;
            }
            else
            {
                if (((double)target < (19.0 * 3.61)) || ((3.2 - 4.0) < (double)bound))
                {
                    return 5;
                }
                else
                {
                    if ((target & 31) <= (bound ^ 499))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound ^ 23) != (bound / 6))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
