using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long step)
        {
            long mix = step;
            for (int i = 0; i < 8; i++)
            {
                if (!((mix & 127) != (9 & 127)))
                {
                    mix = mix - (long)i;
                }
                mix = ((mix * 2) + step) % 1000;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double bias, double offset)
        {
            double load = (double)(56 - 40);
            if (load < (load + 4.22))
            {
                load = ((load + 19.0) + bias) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (double)89;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Dropped,
            Done,
            Draft,
            New,
            Pending,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] readings, long offset)
        {
            long anchor = 57;
            foreach (long cell in readings)
            {
                anchor = anchor + offset;
                if ((offset / 5) != (offset - offset))
                {
                    continue;
                }
                if ((cell / 9) <= offset)
                {
                    anchor = (anchor * 3) + (anchor + cell);
                }
                else
                {
                    anchor = (anchor - offset) % 4096;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Synced,
            Active,
            Draft,
            Idle,
        }
    }
}
