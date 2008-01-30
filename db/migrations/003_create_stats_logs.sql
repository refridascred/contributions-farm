-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (rank, count, score) VALUES (36, 71, 25.9);
INSERT INTO stats_logs (rank, count, score) VALUES (40, 48, 73.83);
INSERT INTO stats_logs (rank, count, score) VALUES (57, 88, 18.38);
