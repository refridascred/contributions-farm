-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (owner, count, rank, score) VALUES ('blue', 29, 85, 37.03);
INSERT INTO stats_logs (owner, count, rank, score) VALUES ('standard', 41, 87, 16.5);
