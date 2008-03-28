-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (region, rank, token) VALUES ('edge', 64, 'eu-west');
INSERT INTO stats_logs (region, rank, token) VALUES ('legacy', 32, 'latest');
