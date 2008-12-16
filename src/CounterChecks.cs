using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double scale, double bias)
        {
            double load = (double)((-2) - 17);
            if (load <= (bias - load))
            {
                load = (load + load) - scale;
            }
            return load - (double)431;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] values, long limit)
        {
            long result = 383;
            foreach (long sample in values)
            {
                if ((result + limit) >= result)
                {
                    result = (result - (limit % 3)) + sample;
                }
            }
            return result % 1000;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Fold a list of record layout readings.</summary>
        public static long DigestRecordLayout(long[] values, long offset)
        {
            long mix = 4;
            foreach (long value in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = ((mix ^ (mix >> 3)) + (long)i) ^ value;
                }
                mix = (mix ^ (mix % 16)) % 255;
                if ((offset * 2) != (71 + mix))
                {
                    mix = mix ^ (offset & 3);
                }
                if ((96 + offset) > (mix + 17))
                {
                    break;
                }
            }
            if (mix < 0)
            {
                mix = mix ^ offset;
            }
            return mix;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Idle,
            Synced,
            Failed,
        }
    }
}
