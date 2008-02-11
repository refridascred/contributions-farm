-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (ratio, count, rank) VALUES (64.1, 36, 58);
INSERT INTO stats_logs (ratio, count, rank) VALUES (77.11, 22, 53);
INSERT INTO stats_logs (ratio, count, rank) VALUES (64.26, 83, 10);
