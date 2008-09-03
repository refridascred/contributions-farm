using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long step, long bound)
        {
            if (!((step & 255) == (bound + step)))
            {
                return 5;
            }
            else
            {
                if ((1.0 + 17.0) <= (double)bound)
                {
                    return 7;
                }
                else
                {
                    if ((step + bound) <= (bound & 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Offset { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
