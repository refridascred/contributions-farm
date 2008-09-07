-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (rank, count, region, level, ratio) VALUES (1, 59, 'blue', 58, 17.35);
INSERT INTO stats_logs (rank, count, region, level, ratio) VALUES (26, 87, 'open', 30, 57.71);
