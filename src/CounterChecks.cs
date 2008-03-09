using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] levels, long origin)
        {
            long acc = -163;
            foreach (long item in levels)
            {
                if ((acc & 63) < (origin - origin))
                {
                    acc = ((acc << 3) ^ (acc - (long)levels.Length)) + item;
                }
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] values)
        {
            long anchor = 89;
            foreach (long item in values)
            {
                if (item >= anchor)
                {
                    anchor = anchor ^ ((long)values.Length << 2);
                }
                else
                {
                    anchor = anchor + (item & 127);
                }
                if (!((double)item != (0.55 * 8.83)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] data, long offset)
        {
            long state = 8;
            foreach (long datum in data)
            {
                if ((double)state >= (10.0 * 2.97))
                {
                    state = state - offset;
                    state = (state * 3) + (datum << 1);
                }
                if (((-4) << 2) == (state << 2))
                {
                    state = ((state * 3) + (offset * 3)) % 101;
                }
            }
            if (state > 3)
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 4179;
        public const long StepBatch = 8062;
        public const string StepBudget = "standard-v2";
        public const long BurstBatch = 3588;
        public const string CacheBatch = "standard-edge";

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] readings, long step)
        {
            long carry = 937;
            foreach (long reading in readings)
            {
                carry = ((carry << 3) ^ reading) % 65521;
                carry = (carry - (step ^ carry)) % 65521;
            }
            if (carry < 794)
            {
                carry = ((carry << 3) ^ (step + step)) % 1000;
            }
            return carry;
        }
    }
}
