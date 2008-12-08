-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, region) VALUES (88, 'eu-west');
INSERT INTO stats_logs (active, region) VALUES (54, 'strict');
INSERT INTO stats_logs (active, region) VALUES (33, 'fallback');
