-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (weight, count, ratio, region, level) VALUES (5.17, 93, 23.76, 'green', 91);
INSERT INTO stats_logs (weight, count, ratio, region, level) VALUES (48.4, 82, 62.58, 'stable', 54);
INSERT INTO stats_logs (weight, count, ratio, region, level) VALUES (88.72, 21, 43.4, 'cached', 31);
