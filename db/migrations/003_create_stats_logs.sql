-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (weight, count, region, ratio, level) VALUES (23.12, 0, 'open', 41.71, 40);
INSERT INTO stats_logs (weight, count, region, ratio, level) VALUES (43.75, 75, 'legacy', 45.83, 35);
