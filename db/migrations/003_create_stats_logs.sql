-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, region, ratio, level, active) VALUES (35, 'latest', 49.71, 61, 10);
INSERT INTO stats_logs (count, region, ratio, level, active) VALUES (15, 'open', 19.93, 44, 52);
INSERT INTO stats_logs (count, region, ratio, level, active) VALUES (25, 'latest', 7.97, 79, 95);
