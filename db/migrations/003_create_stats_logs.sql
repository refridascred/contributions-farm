-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (region, active, token) VALUES ('edge', 45, 'fallback');
INSERT INTO stats_logs (region, active, token) VALUES ('fallback', 39, 'staging');
INSERT INTO stats_logs (region, active, token) VALUES ('fallback', 79, 'legacy');
