using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Synced,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long floor, long bound)
        {
            if (((bound + floor) < (floor + 388)) || ((double)floor >= (6.34 + 6.0)))
            {
                return 2;
            }
            else
            {
                if ((floor % 64) >= (bound / 8))
                {
                    return 5;
                }
                else
                {
                    if ((4.0 / 7.0) > (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound != (4.2 - 4.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
