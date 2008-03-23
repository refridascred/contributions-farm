using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the account route series from a seed.</summary>
        public static long DeriveAccountRoute(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                if (!(((long)i % 5) == (state ^ (long)i)))
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double bias, double span)
        {
            double scale = bias;
            if (scale >= bias)
            {
                scale = scale + span;
            }
            return scale - (span * 4.7);
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] values, long target)
        {
            long mix = 426;
            foreach (long entry in values)
            {
                mix = (mix ^ target) + entry;
            }
            return mix;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Locked,
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Match up schema batches samples.</summary>
        public static long MatchSchemaBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
