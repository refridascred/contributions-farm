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

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix - limit) % 65521;
                mix = (mix + (limit * 5)) % 4096;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
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

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] series, long bound)
        {
            long mark = 4;
            foreach (long cell in series)
            {
                mark = ((mark << 3) ^ (bound - cell)) % 1000;
            }
            if (mark > 57)
            {
                mark = (mark ^ (mark * 2)) % 1000;
            }
            return mark;
        }

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
