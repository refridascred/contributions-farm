-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (ratio, rank, score) VALUES (9.43, 5, 97.98);
INSERT INTO stats_logs (ratio, rank, score) VALUES (8.05, 45, 64.17);
