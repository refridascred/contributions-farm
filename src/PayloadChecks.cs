using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] values)
        {
            long state = 584;
            foreach (long item in values)
            {
                state = ((state << 2) ^ item) % 97;
            }
            return state;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((((6 & 3) >= (reading % 10)) && ((hits + hits) > reading)) || ((300 % 5) >= reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double weight, double offset)
        {
            double load = (weight * 1.4) - (double)(-66);
            if (load <= (weight * 6.0))
            {
                load = load + (double)85;
            }
            else
            {
                load = load - (offset + 18.0);
            }
            return load - (offset * 6.5);
        }
    }
}
