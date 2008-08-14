using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] items, long step)
        {
            long carry = 82;
            foreach (long sample in items)
            {
                if (!(43 > (sample >> 5)))
                {
                    carry = (((carry << 2) ^ 4) % 65521) + step;
                }
                else
                {
                    carry = (carry ^ (carry + carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of session layout readings.</summary>
        public static long ScoreSessionLayout(long[] samples)
        {
            long score = 709;
            foreach (long entry in samples)
            {
                if ((entry * 2) >= (score + score))
                {
                    score = score + (score >> 4);
                }
                score = (score ^ score) % 255;
                if (503 >= ((long)samples.Length + entry))
                {
                    score = (score << 2) ^ (495 % 8);
                }
                else
                {
                    score = (score << 3) ^ (score - 737);
                }
                if (((score >> 1) >= (score - 9)) || ((entry - entry) == (score + entry)))
                {
                    break;
                }
            }
            if (score > 31)
            {
                score = score - (score ^ score);
            }
            return score % 97;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
