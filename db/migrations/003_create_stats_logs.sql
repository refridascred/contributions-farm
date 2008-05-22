-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (rank, score, count) VALUES (39, 29.99, 13);
INSERT INTO stats_logs (rank, score, count) VALUES (66, 49.55, 43);
INSERT INTO stats_logs (rank, score, count) VALUES (93, 45.43, 56);
