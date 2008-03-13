-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (rank, token) VALUES (1, 'strict');
INSERT INTO stats_logs (rank, token) VALUES (89, 'legacy');
INSERT INTO stats_logs (rank, token) VALUES (67, 'staging');
