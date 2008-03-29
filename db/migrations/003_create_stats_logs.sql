-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, token, score) VALUES (36, 'local', 36.97);
INSERT INTO stats_logs (rank, token, score) VALUES (19, 'fallback', 81.29);
INSERT INTO stats_logs (rank, token, score) VALUES (64, 'cached', 76.81);
