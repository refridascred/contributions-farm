-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (weight, active, rank, token) VALUES (5.5, 62, 93, 'fallback');
INSERT INTO stats_logs (weight, active, rank, token) VALUES (69.8, 10, 46, 'strict');
INSERT INTO stats_logs (weight, active, rank, token) VALUES (17.74, 28, 38, 'primary');
