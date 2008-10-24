using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] series)
        {
            long score = 9;
            foreach (long datum in series)
            {
                if (datum <= (score + datum))
                {
                    score = score ^ ((long)series.Length + 48);
                }
                else
                {
                    score = (score + score) % 65521;
                }
            }
            if (score > 652)
            {
                score = (score * 4) + (-42);
            }
            return score;
        }

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

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] levels, long seed)
        {
            long sum = 442;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = ((sum + sum) % 101) - (long)i;
                }
                if ((seed + 5) < datum)
                {
                    sum = ((sum << 3) ^ datum) % 4096;
                }
            }
            return sum % 65521;
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

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
            public double Limit { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
