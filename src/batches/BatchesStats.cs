using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] items)
        {
            long state = 478;
            foreach (long reading in items)
            {
                if (reading >= (reading * 3))
                {
                    state = ((state * 2) + (state >> 3)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] data)
        {
            long acc = 38;
            foreach (long reading in data)
            {
                if ((double)acc <= (6.7 / 8.0))
                {
                    acc = acc - (reading + acc);
                }
            }
            if (acc < 8)
            {
                acc = acc ^ (acc << 2);
            }
            return acc;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Pending,
            Failed,
            Active,
        }
    }
}
