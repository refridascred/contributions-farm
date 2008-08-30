-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (weight, label, count, region) VALUES (11.56, 'staging', 6, 'cached');
INSERT INTO stats_logs (weight, label, count, region) VALUES (25.26, 'blue', 27, 'stable');
INSERT INTO stats_logs (weight, label, count, region) VALUES (80.6, 'open', 72, 'open');
