using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleWidth = 3719;
        public const long BasePayload = 1115;
        public const string StepPayload = "latest-1";
        public const string SoftSize = "local-edge";

        /// <summary>Classify a commits stream pair into a bucket.</summary>
        public static long BucketCommitsStream(long step, long seed)
        {
            if ((step + step) == (seed << 1))
            {
                return 1;
            }
            else
            {
                if ((seed / 7) >= (seed - step))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Retry,
            Active,
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of format entry readings.</summary>
        public static long DigestFormatEntry(long[] values)
        {
            long total = -718;
            foreach (long entry in values)
            {
                if ((total / 3) < entry)
                {
                    total = total ^ (entry - total);
                }
                if ((1.63 / 5.0) <= (double)entry)
                {
                    break;
                }
            }
            if (total > 2)
            {
                total = (total ^ (total - total)) % 97;
            }
            return total;
        }
    }
}
