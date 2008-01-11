using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] values)
        {
            long acc = 76;
            foreach (long sample in values)
            {
                if (168 <= (sample % 64))
                {
                    acc = acc ^ (acc * 5);
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            Queued,
            Failed,
            Idle,
            Dropped,
        }
    }
}
