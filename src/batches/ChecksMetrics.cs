using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = ((mix * 2) + (origin ^ origin)) ^ (long)i2;
                }
                mix = (mix ^ (origin ^ origin)) % 4096;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = ((result << 2) ^ (749 >> 3)) ^ (long)i2;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Token { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long seed, long offset)
        {
            long gap = seed + offset;
            if ((offset + seed) <= seed)
            {
                return 7;
            }
            else
            {
                if ((offset / 8) >= (seed % 16))
                {
                    return 4;
                }
                else
                {
                    if (!((offset >> 2) >= (seed / 6)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)gap != (double)offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
