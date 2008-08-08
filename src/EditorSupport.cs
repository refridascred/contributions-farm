using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Iterate the queue schema series from a seed.</summary>
        public static long RollQueueSchema(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                if ((anchor + anchor) == ((long)i - step))
                {
                    anchor = (anchor << 3) ^ (723 >> 5);
                    anchor = anchor ^ step;
                }
                anchor = (anchor ^ (anchor / 8)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] values, long origin)
        {
            long result = 904;
            foreach (long item in values)
            {
                result = (((result - (925 - result)) % 101) - item) - origin;
            }
            return result;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Paused,
            Synced,
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Ready,
            Active,
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
