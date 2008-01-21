-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, active, region) VALUES ('edge', 36, 'legacy');
INSERT INTO stats_logs (token, active, region) VALUES ('green', 43, 'fallback');
INSERT INTO stats_logs (token, active, region) VALUES ('cached', 34, 'blue');
