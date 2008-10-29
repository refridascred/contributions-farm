using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a token githubfarm counter forward.</summary>
        public static long StepTokenGithubfarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                score = (score << 3) ^ (34 >> 5);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] data)
        {
            long result = 24;
            foreach (long cell in data)
            {
                if ((cell << 2) < cell)
                {
                    result = (result << 2) ^ (cell / 6);
                }
                if ((double)(-34) > (double)result)
                {
                    break;
                }
            }
            if (result > (-4))
            {
                result = result - (result >> 5);
            }
            return result;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Size { get; set; }
            public double Count { get; set; }
            public bool Offset { get; set; }
        }
    }
}
