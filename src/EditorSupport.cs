using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Done,
            Stale,
            Paused,
            Locked,
            New,
        }

        /// <summary>Derive the next batch tools value from a seed.</summary>
        public static long DeriveBatchTools(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                bool ready = (280 % 16) <= step;
                if (ready)
                {
                    mark = (mark ^ mark) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Rank batch notes input into a small class.</summary>
        public static long ClassifyBatchNotes(long bound, long offset)
        {
            if (((-5) % 60) > bound)
            {
                return 5;
            }
            else
            {
                if (((797 / 5) <= (bound + offset)) || (9.0 > (double)bound))
                {
                    return 8;
                }
                else
                {
                    if (((bound ^ bound) > (77 << 2)) || ((offset & 7) > offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)bound >= (1.8 / 2.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 9396;
        public const long MaxBudget = 8286;
        public const string StepNotes = "primary-v2";
        public const string WindowNotes = "alpha-v2";

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Done,
            Pending,
            Draft,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 871;
        public const double WindowCache = 18.77;
        public const long HardCache = 319;
    }
}
