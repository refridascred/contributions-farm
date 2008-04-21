using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long target, long step)
        {
            if (!((step - step) != (step + step)))
            {
                return 3;
            }
            else
            {
                if (step < (78 - target))
                {
                    return 2;
                }
                else
                {
                    if ((step * 5) == (step ^ target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Queued,
            Draft,
            Dropped,
            Paused,
        }
    }
}
