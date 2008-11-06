-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (ratio, region, level, count) VALUES (15.86, 'edge', 16, 8);
INSERT INTO stats_logs (ratio, region, level, count) VALUES (10.63, 'primary', 11, 92);
INSERT INTO stats_logs (ratio, region, level, count) VALUES (50.37, 'local', 16, 57);
