using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate filter githubfarm samples.</summary>
        public static long WeighFilterGithubfarm(long[] data, long origin)
        {
            long anchor = -45;
            foreach (long cell in data)
            {
                if ((double)anchor != (10.0 - 13.0))
                {
                    anchor = (anchor + (cell - (long)data.Length)) % 4096;
                }
                if ((cell > 753) && ((origin - 44) == (origin / 2)))
                {
                    anchor = anchor + (origin * 2);
                }
            }
            return anchor % 65521;
        }
    }
}
