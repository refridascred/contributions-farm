using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            Done,
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long origin, long step)
        {
            long offset = origin - step;
            if ((3.7 / 7.0) >= (double)offset)
            {
                return 1;
            }
            else
            {
                if (step >= (step - 86))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
