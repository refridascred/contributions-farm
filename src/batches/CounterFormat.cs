using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a tools schema pair into a bucket.</summary>
        public static long BucketToolsSchema(long floor, long origin)
        {
            if ((origin % 24) >= (floor - floor))
            {
                return 8;
            }
            else
            {
                if ((origin + origin) <= floor)
                {
                    return 4;
                }
                else
                {
                    if ((6 + origin) != (3 - floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if (origin >= (origin - origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
