-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (ratio, count, level, region, owner) VALUES (5.8, 59, 66, 'blue', 'stable');
INSERT INTO stats_logs (ratio, count, level, region, owner) VALUES (48.05, 28, 91, 'blue', 'open');
INSERT INTO stats_logs (ratio, count, level, region, owner) VALUES (8.23, 7, 52, 'stable', 'latest');
