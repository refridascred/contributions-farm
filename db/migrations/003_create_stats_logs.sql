-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, region, active) VALUES (47, 'blue', 10);
INSERT INTO stats_logs (rank, region, active) VALUES (80, 'blue', 59);
INSERT INTO stats_logs (rank, region, active) VALUES (56, 'latest', 50);
