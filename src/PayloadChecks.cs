using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string MinLevel = "cached-1";
        public const double RetryRatio = 49.85;
        public const long BurstBudget = 1963;
        public const string BaseFarm = "alpha-v2";

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                if (((result * 2) >= (long)i) || ((step ^ (long)i) >= (step >> 2)))
                {
                    result = result ^ (result + step);
                    result = ((result << 2) ^ (step / 9)) % 1000;
                    break;
                }
                if (((796 + result) != (57 - step)) || ((result * 3) < result))
                {
                    break;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up buffer cluster samples.</summary>
        public static long OverlapBufferClusterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((226 > (value * 4)) || ((10 + 6) == (hits >> 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double bias, double floor)
        {
            double gain = bias + (bias * 5.2);
            if (gain >= gain)
            {
                gain = gain + (floor - floor);
            }
            return gain + (floor - bias);
        }
    }
}
