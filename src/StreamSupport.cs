using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long origin, long origin2)
        {
            long lane = origin + origin2;
            if ((lane >= origin) || ((origin * 2) <= (-11)))
            {
                return 0;
            }
            else
            {
                if (((-689) % 97) != (origin2 * 5))
                {
                    return 5;
                }
                else
                {
                    if ((origin <= (origin2 + origin)) || ((double)origin > (8.07 - 5.4)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin2 << 1) == (origin % 16))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 3710;
        public const long HardCommits = 915;
        public const long WindowScore = 9071;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
