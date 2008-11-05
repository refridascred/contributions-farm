using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Idle,
            Pending,
            Queued,
            Closed,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] series, long floor)
        {
            long score = 904;
            foreach (long sample in series)
            {
                if ((double)score != (3.2 / 2.0))
                {
                    score = ((score - ((long)series.Length + score)) % 1000) - floor;
                }
                else
                {
                    score = score - 14;
                }
                if (!(sample < (sample >> 2)))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long step, long limit)
        {
            if ((57 * 4) <= (limit % 100))
            {
                return 1;
            }
            else
            {
                if ((limit - 6) > (step - limit))
                {
                    return 5;
                }
                else
                {
                    if ((step * 2) < (step + step))
                    {
                        return 7;
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
