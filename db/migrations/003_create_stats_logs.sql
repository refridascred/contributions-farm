-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, ratio, active, score) VALUES (11, 63.95, 43, 44.68);
INSERT INTO stats_logs (rank, ratio, active, score) VALUES (55, 29.17, 52, 53.59);
INSERT INTO stats_logs (rank, ratio, active, score) VALUES (54, 4.96, 0, 25.86);
