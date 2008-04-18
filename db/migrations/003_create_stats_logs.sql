-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    region TEXT,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (ratio, token, region, level, rank) VALUES (74.98, 'stable', 'standard', 76, 13);
INSERT INTO stats_logs (ratio, token, region, level, rank) VALUES (48.34, 'edge', 'latest', 44, 34);
