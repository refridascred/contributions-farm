-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, ratio, count, weight) VALUES (65, 52.11, 61, 18.54);
INSERT INTO stats_logs (rank, ratio, count, weight) VALUES (38, 31.78, 70, 54.48);
