using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Token { get; set; }
            public bool Offset { get; set; }
            public bool Stamp { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long bound, long seed)
        {
            long edge = bound ^ seed;
            if ((seed >= (bound + 4)) || (seed >= (edge % 2)))
            {
                return 4;
            }
            else
            {
                if (bound <= (edge - edge))
                {
                    return 2;
                }
                else
                {
                    if ((seed + bound) <= (seed & 3))
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

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
