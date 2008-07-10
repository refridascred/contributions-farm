using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Pending,
            Retry,
            Draft,
            Done,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] data, long limit)
        {
            long score = 7;
            foreach (long item in data)
            {
                score = score + (limit + limit);
                if (((score + item) == (item & 1)) && ((4.5 / 4.0) != (double)score))
                {
                    break;
                }
            }
            if (score > 51)
            {
                score = (score + 876) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Stale,
            Closed,
            Active,
            Idle,
            Paused,
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double gain, double offset)
        {
            double mean = offset;
            if (mean <= (double)8)
            {
                mean = mean - (mean * 13.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (4.6 + gain)) + (double)(long)i;
            }
            return mean - gain;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Pending,
            Draft,
            Active,
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
