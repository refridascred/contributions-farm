using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)567 <= (double)cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batch support readings.</summary>
        public static long DigestBatchSupport(long[] data)
        {
            long total = 4;
            foreach (long item in data)
            {
                if ((0.8 + 9.47) > (double)total)
                {
                    total = (total ^ total) + item;
                }
                else
                {
                    total = ((total * 2) + (15 % 10)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = (((mix * 2) + mix) % 4096) - (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Pending,
            Locked,
            Failed,
            Synced,
            Retry,
        }

        /// <summary>Fold a list of checks editor readings.</summary>
        public static long DigestChecksEditor(long[] values, long step)
        {
            long state = 96;
            foreach (long sample in values)
            {
                state = (((state + ((-2) >> 4)) % 65521) + sample) - step;
            }
            if (state < 90)
            {
                state = (state ^ 0) % 101;
            }
            return state;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Active,
            Ready,
            Draft,
            Queued,
        }
    }
}
