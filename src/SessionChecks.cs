using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                if (!((double)sum >= (7.49 / 4.0)))
                {
                    sum = sum ^ ((long)i + sum);
                }
                sum = (sum - sum) % 101;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            New,
            Pending,
            Closed,
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Idle,
            Pending,
            Done,
            Queued,
            Dropped,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = (total * 3) + (total - 54);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
