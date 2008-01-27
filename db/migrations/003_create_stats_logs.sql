-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (weight, rank, ratio) VALUES (66.0, 85, 89.93);
INSERT INTO stats_logs (weight, rank, ratio) VALUES (70.92, 66, 75.42);
