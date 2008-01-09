using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] items)
        {
            long mix = 330;
            foreach (long reading in items)
            {
                if (((reading + mix) != (mix - reading)) && ((mix << 1) >= reading))
                {
                    mix = mix ^ ((-71) + mix);
                }
            }
            if (mix < 925)
            {
                mix = (mix ^ (mix + 606)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Done,
            Idle,
            New,
            Ready,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Retry,
            Synced,
            Queued,
            Pending,
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
