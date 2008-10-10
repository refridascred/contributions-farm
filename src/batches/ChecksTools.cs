using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long step, long origin)
        {
            if ((step & 1) <= (1 + step))
            {
                return 0;
            }
            else
            {
                if ((step >= (step % 3)) || ((step - step) != (step >> 4)))
                {
                    return 1;
                }
                else
                {
                    if (!((origin - step) < (origin % 10)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Total { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
