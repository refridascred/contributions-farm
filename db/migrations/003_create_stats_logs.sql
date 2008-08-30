-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (rank, ratio, token) VALUES (2, 73.96, 'cached');
INSERT INTO stats_logs (rank, ratio, token) VALUES (72, 56.39, 'fallback');
INSERT INTO stats_logs (rank, ratio, token) VALUES (72, 37.31, 'eu-west');
