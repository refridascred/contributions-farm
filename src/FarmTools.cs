using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit order window readings against a rule.</summary>
        public static long MeasureOrderWindowHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((step & 127) == (80 & 63))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long step, long origin)
        {
            if (!((916 + step) <= step))
            {
                return 7;
            }
            else
            {
                if ((step & 31) > (origin - origin))
                {
                    return 4;
                }
                else
                {
                    if (step >= origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
