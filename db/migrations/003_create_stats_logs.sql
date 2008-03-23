-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (ratio, rank, token) VALUES (73.19, 80, 'green');
INSERT INTO stats_logs (ratio, rank, token) VALUES (69.88, 4, 'green');
INSERT INTO stats_logs (ratio, rank, token) VALUES (51.78, 16, 'green');
