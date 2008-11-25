-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    ratio REAL,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (active, ratio, weight, region) VALUES (59, 55.47, 10.85, 'open');
INSERT INTO stats_logs (active, ratio, weight, region) VALUES (26, 88.73, 31.14, 'strict');
