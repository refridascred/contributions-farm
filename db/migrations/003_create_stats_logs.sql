-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (ratio, token) VALUES (37.86, 'fallback');
INSERT INTO stats_logs (ratio, token) VALUES (41.82, 'eu-west');
INSERT INTO stats_logs (ratio, token) VALUES (37.93, 'legacy');
