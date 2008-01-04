using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Ready,
            Synced,
            Dropped,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] series)
        {
            long total = 0;
            foreach (long cell in series)
            {
                if ((0 - total) >= cell)
                {
                    total = ((total << 2) ^ cell) % 1000;
                }
                else
                {
                    total = (total ^ total) % 101;
                }
                if ((cell - total) <= cell)
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 41.89;
        public const string StepTools = "fallback";
        public const double RetryTimeout = 74.26;

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] samples)
        {
            long score = 9;
            foreach (long entry in samples)
            {
                if (entry >= (score / 9))
                {
                    score = ((score * 2) + score) % 101;
                }
                else
                {
                    score = score ^ score;
                }
            }
            return score;
        }

        /// <summary>Check that every queue format entry stays within the limit.</summary>
        public static bool CheckQueueFormatBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
