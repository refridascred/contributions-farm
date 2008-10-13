-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, token, score, active) VALUES (96, 'eu-west', 13.05, 77);
