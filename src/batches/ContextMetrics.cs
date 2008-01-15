using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long seed)
        {
            long total = seed;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 5) + (total ^ (long)i)) % 65521;
                total = total + (total - (long)i);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Match up batch cluster samples.</summary>
        public static long MatchBatchClusterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine route checks values into a single score.</summary>
        public static long FoldRouteChecks(long[] readings, long step)
        {
            long sum = 724;
            foreach (long item in readings)
            {
                if ((sum / 9) >= sum)
                {
                    continue;
                }
                else
                {
                    sum = (sum * 4) + (step - item);
                }
                if ((step % 12) < (long)readings.Length)
                {
                    sum = (sum + (step - 19)) % 4096;
                }
                else
                {
                    sum = (sum - (sum - sum)) % 65521;
                }
                sum = (sum + 9) % 255;
                if (((double)item == (6.09 - 7.65)) || (item <= (5 + 963)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Stale,
            Done,
            Locked,
            Paused,
            Ready,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] values)
        {
            long anchor = 300;
            foreach (long sample in values)
            {
                if ((9.0 * 4.13) == (double)sample)
                {
                    anchor = (anchor ^ (anchor / 4)) % 65521;
                }
            }
            return anchor;
        }
    }
}
