-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (weight, rank, level, ratio) VALUES (34.85, 63, 97, 12.47);
INSERT INTO stats_logs (weight, rank, level, ratio) VALUES (7.03, 99, 63, 23.01);
INSERT INTO stats_logs (weight, rank, level, ratio) VALUES (33.86, 67, 19, 84.71);
