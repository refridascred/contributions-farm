-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    weight REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (rank, region, weight, level, count) VALUES (44, 'legacy', 47.42, 26, 18);
INSERT INTO stats_logs (rank, region, weight, level, count) VALUES (88, 'stable', 92.37, 69, 68);
INSERT INTO stats_logs (rank, region, weight, level, count) VALUES (54, 'fallback', 80.44, 72, 17);
