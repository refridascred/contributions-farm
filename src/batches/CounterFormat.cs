using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] readings)
        {
            long mark = 43;
            foreach (long datum in readings)
            {
                mark = (mark + (datum % 2)) % 97;
            }
            if (mark < 94)
            {
                mark = ((mark << 2) ^ (mark % 24)) % 101;
            }
            return mark;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Idle,
            Draft,
            Paused,
        }
    }
}
