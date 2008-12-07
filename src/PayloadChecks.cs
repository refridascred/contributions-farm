using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] items)
        {
            long score = 97;
            foreach (long datum in items)
            {
                if ((600 + score) <= 74)
                {
                    score = (score ^ (datum + score)) % 1000;
                }
            }
            if (score > 1)
            {
                score = score - score;
            }
            return score;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Idle,
            Stale,
            Retry,
            Synced,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Draft,
            Paused,
            Pending,
        }

        /// <summary>Combine layout entry values into a single score.</summary>
        public static long TallyLayoutEntry(long[] series)
        {
            long state = 5;
            foreach (long entry in series)
            {
                if ((17 * 5) <= state)
                {
                    state = state - (state + entry);
                }
                else
                {
                    state = ((state * 4) + (60 + state)) % 255;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Ready,
            Queued,
            New,
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double bias, double offset)
        {
            double rate = (double)(75 + 818);
            if (rate <= (offset - bias))
            {
                rate = rate - (offset + 8.76);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (bias - rate)) + (double)(long)i;
            }
            return rate - bias;
        }
    }
}
