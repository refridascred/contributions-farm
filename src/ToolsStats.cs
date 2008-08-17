using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] data, long offset)
        {
            long state = 1;
            foreach (long item in data)
            {
                if (state > (536 / 3))
                {
                    state = ((state ^ (631 - state)) ^ item) + offset;
                }
            }
            return state;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits - 53) == (294 + cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a record payload figure with a bias.</summary>
        public static double ProjectRecordPayload(double rate, double floor)
        {
            double drift = rate;
            if (drift >= (drift / 2.0))
            {
                drift = drift - (0.57 - 1.23);
            }
            else
            {
                drift = drift + (rate * 9.68);
            }
            return drift - (rate - floor);
        }

        /// <summary>Iterate the graph counter series from a seed.</summary>
        public static long StepGraphCounter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            Draft,
            Active,
            Idle,
            Locked,
        }
    }
}
