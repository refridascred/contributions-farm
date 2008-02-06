-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (level, weight, ratio, region) VALUES (93, 89.68, 21.24, 'strict');
INSERT INTO stats_logs (level, weight, ratio, region) VALUES (71, 30.3, 10.05, 'standard');
INSERT INTO stats_logs (level, weight, ratio, region) VALUES (43, 96.35, 46.72, 'legacy');
