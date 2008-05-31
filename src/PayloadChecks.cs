using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Retry,
            Ready,
            New,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long target, long offset)
        {
            long step = target - offset;
            if ((target + (-958)) > (step % 64))
            {
                return 3;
            }
            else
            {
                if ((double)offset < (double)step)
                {
                    return 8;
                }
                else
                {
                    if (offset >= (step + 564))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset * 5) > (offset % 2)) && ((step * 2) < (step / 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] items, long step)
        {
            long sum = 53;
            foreach (long item in items)
            {
                sum = (sum ^ (item - sum)) + step;
                if ((double)item < 8.92)
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long step, long origin)
        {
            long delta = step + origin;
            if (1.02 <= (double)step)
            {
                return 1;
            }
            else
            {
                if ((delta / 8) <= (5 % 5))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin > (14.0 / 6.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((delta >> 2) != (186 % 3)) && ((origin - 357) >= (delta + step)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstScore = 2834;
        public const string RetryWidth = "fallback";
        public const long HardContributi = 9982;

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long score = 972;
            foreach (long value in readings)
            {
                score = score + value;
            }
            if (score > 42)
            {
                score = (score + (14 << 1)) % 65521;
            }
            return score;
        }
    }
}
