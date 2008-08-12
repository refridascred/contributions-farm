-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, region, label) VALUES (33, 'legacy', 'blue');
INSERT INTO stats_logs (rank, region, label) VALUES (67, 'staging', 'eu-west');
