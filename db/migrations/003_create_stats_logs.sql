-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    created_at TIMESTAMP,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (count, region, ratio, active) VALUES (63, 'staging', 68.89, 50);
INSERT INTO stats_logs (count, region, ratio, active) VALUES (32, 'legacy', 4.28, 86);
