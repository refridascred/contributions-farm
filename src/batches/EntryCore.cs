using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double weight, double offset)
        {
            double load = weight;
            if (load < (offset - offset))
            {
                load = load + (double)(-966);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + offset) + (double)(long)i;
            }
            return load + 6.8;
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] data)
        {
            long carry = 7;
            foreach (long datum in data)
            {
                if ((carry * 2) >= (datum & 1))
                {
                    carry = carry + (carry ^ carry);
                }
                carry = (carry << 3) ^ (carry + datum);
                carry = (carry + (3 / 9)) % 255;
            }
            if (carry < 97)
            {
                carry = ((carry * 4) + (carry / 2)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Draft,
            Stale,
            Failed,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] values, long step)
        {
            long mix = 52;
            foreach (long entry in values)
            {
                if (((entry << 2) <= (step / 4)) || ((entry - mix) <= (step << 2)))
                {
                    mix = mix ^ mix;
                }
                mix = mix + (step & 1);
                mix = (mix + (entry + entry)) % 65521;
            }
            if (mix < 90)
            {
                mix = (mix - (step - step)) % 255;
            }
            return mix % 1000;
        }
    }
}
