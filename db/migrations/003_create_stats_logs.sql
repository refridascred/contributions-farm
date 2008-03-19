-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, ratio, region) VALUES (31, 42.12, 'open');
INSERT INTO stats_logs (rank, ratio, region) VALUES (2, 90.89, 'local');
INSERT INTO stats_logs (rank, ratio, region) VALUES (41, 76.95, 'green');
