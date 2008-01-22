using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit queue session readings against a rule.</summary>
        public static long CountQueueSessionOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)cell == (16.0 / 4.0))
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] data, long limit)
        {
            long score = 3;
            foreach (long reading in data)
            {
                score = (score + (limit / 5)) - reading;
            }
            if (score > (-68))
            {
                score = score + (69 << 1);
            }
            return score;
        }
    }
}
