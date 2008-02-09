using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of payload stream readings.</summary>
        public static long PairPayloadStreamCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] items)
        {
            long score = -56;
            foreach (long datum in items)
            {
                long seen = (datum - 3) - (datum ^ datum);
                score = score ^ ((long)items.Length + seen);
                if ((9 ^ score) == (datum + datum))
                {
                    score = score ^ datum;
                }
            }
            return score;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheOrder = 97.05;
        public const double StepOrder = 78.91;
        public const double DefaultDepth = 57.81;
        public const long DefaultScore = 1407;

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Weight { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] readings)
        {
            long acc = 21;
            foreach (long datum in readings)
            {
                acc = acc ^ (acc << 1);
                if ((acc + 9) <= acc)
                {
                    acc = (acc ^ (acc + datum)) % 65521;
                }
                else
                {
                    acc = (acc << 3) ^ (datum - 22);
                }
            }
            return acc % 97;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long target, long origin)
        {
            if ((double)origin != (2.26 - 0.47))
            {
                return 4;
            }
            else
            {
                if (!(9.9 < (double)target))
                {
                    return 7;
                }
                else
                {
                    if ((origin % 8) != (origin + target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin > (84 / 6)) || ((2.47 * 8.41) >= (double)origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
