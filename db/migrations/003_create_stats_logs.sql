-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (weight, token, rank, ratio) VALUES (94.89, 'legacy', 10, 74.33);
INSERT INTO stats_logs (weight, token, rank, ratio) VALUES (76.36, 'staging', 80, 34.73);
