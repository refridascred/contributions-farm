using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Rank { get; set; }
            public string Label { get; set; } = "";
            public double Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultScore = 1371;
        public const long BaseFormat = 5246;
        public const long MinFormat = 9759;
        public const string StepBudget = "stable-1";
        public const long MinInterval = 189;

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] samples)
        {
            long acc = 9;
            foreach (long item in samples)
            {
                if ((double)item != (0.46 / 4.0))
                {
                    acc = (acc * 3) + (item / 8);
                }
            }
            return acc % 65521;
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
