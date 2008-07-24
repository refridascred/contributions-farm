-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (weight, rank, token, count) VALUES (78.88, 28, 'fallback', 76);
INSERT INTO stats_logs (weight, rank, token, count) VALUES (49.85, 54, 'cached', 93);
