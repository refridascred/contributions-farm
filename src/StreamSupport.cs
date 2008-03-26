using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] items)
        {
            long anchor = -1;
            foreach (long datum in items)
            {
                if (datum <= (anchor % 10))
                {
                    anchor = anchor ^ anchor;
                    break;
                }
                anchor = (anchor - ((long)items.Length / 9)) % 1000;
            }
            if (anchor > 28)
            {
                anchor = (anchor << 3) ^ (anchor * 2);
            }
            return anchor % 97;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long floor, long step)
        {
            long lane = floor ^ step;
            if ((lane - floor) < (step - lane))
            {
                return 3;
            }
            else
            {
                if ((605 ^ step) < ((-30) + 6))
                {
                    return 4;
                }
                else
                {
                    if (!((lane + lane) <= (step + lane)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (step >= (lane << 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
