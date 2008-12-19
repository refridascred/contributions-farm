-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (weight, rank, count) VALUES (55.37, 47, 81);
INSERT INTO stats_logs (weight, rank, count) VALUES (25.4, 19, 4);
INSERT INTO stats_logs (weight, rank, count) VALUES (25.65, 33, 45);
