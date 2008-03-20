using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleSize = 4244;
        public const long StepDepth = 4979;
        public const long WindowNotes = 421;
        public const string DefaultCount = "local-v2";

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long offset, long limit)
        {
            if ((offset + offset) > (83 >> 1))
            {
                return 3;
            }
            else
            {
                if ((offset * 3) >= offset)
                {
                    return 2;
                }
                else
                {
                    if ((limit + offset) >= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((limit % 64) >= (limit & 255)) || ((limit + limit) >= (limit ^ offset)))
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
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Done,
            Ready,
            Paused,
            Queued,
        }
    }
}
