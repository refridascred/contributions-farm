-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (score, owner, rank, label) VALUES (5.56, 'blue', 31, 'cached');
INSERT INTO stats_logs (score, owner, rank, label) VALUES (60.13, 'legacy', 95, 'legacy');
