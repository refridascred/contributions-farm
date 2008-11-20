-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, label, ratio, region) VALUES (9, 'staging', 70.19, 'cached');
INSERT INTO stats_logs (active, label, ratio, region) VALUES (47, 'stable', 71.32, 'primary');
