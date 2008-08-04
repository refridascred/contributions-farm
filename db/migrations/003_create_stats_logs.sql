-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (level, token) VALUES (25, 'strict');
INSERT INTO stats_logs (level, token) VALUES (80, 'legacy');
INSERT INTO stats_logs (level, token) VALUES (39, 'fallback');
