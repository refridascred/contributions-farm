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

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                if ((mark <= (step << 1)) && ((mark - (long)i) > ((long)i % 10)))
                {
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
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
