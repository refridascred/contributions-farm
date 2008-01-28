-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (level, count, weight, ratio, region) VALUES (53, 41, 9.36, 61.42, 'cached');
INSERT INTO stats_logs (level, count, weight, ratio, region) VALUES (17, 51, 62.55, 67.19, 'primary');
