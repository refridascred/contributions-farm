-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (ratio, region, active) VALUES (40.46, 'fallback', 11);
INSERT INTO stats_logs (ratio, region, active) VALUES (82.29, 'cached', 70);
INSERT INTO stats_logs (ratio, region, active) VALUES (98.44, 'edge', 6);
