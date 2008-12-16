using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Done,
            Synced,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((double)59 < (double)seen) || ((7 / 6) != (sample ^ limit)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Draft,
            Dropped,
            Queued,
            Active,
            Paused,
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double gain, double bias)
        {
            double weight = gain / 5.0;
            if (weight > gain)
            {
                weight = weight - bias;
            }
            return weight - bias;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] samples)
        {
            long state = 75;
            foreach (long entry in samples)
            {
                if (1.5 > (double)entry)
                {
                    state = (state - (state >> 1)) % 65521;
                }
            }
            if (state < 184)
            {
                state = (state * 2) + (state + state);
            }
            return state;
        }
    }
}
