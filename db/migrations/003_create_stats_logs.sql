-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (token, rank, score, owner) VALUES ('cached', 34, 50.97, 'primary');
INSERT INTO stats_logs (token, rank, score, owner) VALUES ('staging', 25, 85.26, 'strict');
INSERT INTO stats_logs (token, rank, score, owner) VALUES ('green', 94, 67.94, 'cached');
