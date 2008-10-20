-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (weight, count, active, rank, level) VALUES (18.46, 14, 99, 51, 80);
INSERT INTO stats_logs (weight, count, active, rank, level) VALUES (49.94, 86, 39, 21, 78);
INSERT INTO stats_logs (weight, count, active, rank, level) VALUES (54.97, 94, 20, 23, 45);
