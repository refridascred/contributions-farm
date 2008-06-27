-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (rank, weight, token) VALUES (99, 93.53, 'open');
INSERT INTO stats_logs (rank, weight, token) VALUES (74, 88.32, 'legacy');
INSERT INTO stats_logs (rank, weight, token) VALUES (83, 24.54, 'blue');
