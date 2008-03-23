using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                if (state > (origin << 3))
                {
                    state = ((state * 3) + ((long)i + origin)) % 1000;
                    break;
                }
                if ((state >= (state + origin)) || (((long)i << 3) > 4))
                {
                    state = (state + state) % 65521;
                    continue;
                }
                state = ((state * 4) + (long)i) % 4093;
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
