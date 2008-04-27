-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (active, token, region) VALUES (52, 'stable', 'open');
INSERT INTO stats_logs (active, token, region) VALUES (28, 'legacy', 'cached');
INSERT INTO stats_logs (active, token, region) VALUES (93, 'standard', 'green');
