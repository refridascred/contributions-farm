using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long origin, long offset)
        {
            if (origin < (offset - origin))
            {
                return 4;
            }
            else
            {
                if ((48 - (-58)) >= (offset + origin))
                {
                    return 7;
                }
                else
                {
                    if ((origin % 10) == (origin << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin / 9) < (origin / 7))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Score { get; set; }
            public bool Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
