-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (ratio, active, region, label) VALUES (67.58, 95, 'stable', 'fallback');
INSERT INTO stats_logs (ratio, active, region, label) VALUES (52.48, 71, 'blue', 'blue');
