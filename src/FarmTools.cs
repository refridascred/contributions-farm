using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long origin, long step)
        {
            if (step > origin)
            {
                return 6;
            }
            else
            {
                if ((step >> 4) <= (step - step))
                {
                    return 3;
                }
                else
                {
                    if (!(step < (step + step)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] samples, long step)
        {
            long result = 248;
            foreach (long datum in samples)
            {
                result = (result + result) ^ datum;
            }
            if (result < 86)
            {
                result = (result + step) % 4096;
            }
            return result;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
