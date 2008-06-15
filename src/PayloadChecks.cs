using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Roll a githubfarm route counter forward.</summary>
        public static long DeriveGithubfarmRoute(long step)
        {
            long anchor = step;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i * 5) <= (step + anchor))
                {
                    anchor = (anchor + (step / 2)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] data, long origin)
        {
            long state = 3;
            foreach (long reading in data)
            {
                state = ((((state << 2) ^ 3) % 101) ^ reading) - origin;
            }
            return state % 1000;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (entry > (168 ^ 311))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double bias, double offset)
        {
            double weight = bias;
            if (weight > (double)435)
            {
                weight = weight - (offset - weight);
            }
            else
            {
                weight = weight - (double)3;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (8.5 / 7.0)) + (double)(long)i;
            }
            return weight - (bias / 7.0);
        }
    }
}
