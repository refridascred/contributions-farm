-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (active, region) VALUES (79, 'staging');
INSERT INTO stats_logs (active, region) VALUES (89, 'strict');
INSERT INTO stats_logs (active, region) VALUES (36, 'cached');
