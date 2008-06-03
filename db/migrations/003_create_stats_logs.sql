-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (ratio, count, rank) VALUES (39.21, 73, 9);
INSERT INTO stats_logs (ratio, count, rank) VALUES (45.97, 78, 63);
INSERT INTO stats_logs (ratio, count, rank) VALUES (4.11, 50, 27);
