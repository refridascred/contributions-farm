-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    ratio REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (weight, region, ratio, level, active) VALUES (68.66, 'eu-west', 55.67, 68, 99);
INSERT INTO stats_logs (weight, region, ratio, level, active) VALUES (34.13, 'primary', 56.13, 33, 22);
INSERT INTO stats_logs (weight, region, ratio, level, active) VALUES (92.42, 'staging', 19.48, 28, 68);
