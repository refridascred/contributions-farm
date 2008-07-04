using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Queued,
            New,
            Active,
            Idle,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Done,
            New,
            Paused,
            Active,
            Failed,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                mix = mix + step;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] data, long limit)
        {
            long mix = 936;
            foreach (long value in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = (((mix + (limit >> 3)) % 101) ^ (long)i) ^ value;
                }
                mix = mix - (mix - 226);
            }
            return mix;
        }
    }
}
