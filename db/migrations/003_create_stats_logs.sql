-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (ratio, region, label, score, active) VALUES (9.35, 'fallback', 'green', 52.29, 83);
INSERT INTO stats_logs (ratio, region, label, score, active) VALUES (10.42, 'staging', 'primary', 24.54, 7);
