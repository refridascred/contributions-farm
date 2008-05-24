-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (count, weight, rank) VALUES (68, 56.52, 2);
INSERT INTO stats_logs (count, weight, rank) VALUES (38, 64.81, 72);
INSERT INTO stats_logs (count, weight, rank) VALUES (80, 61.42, 37);
