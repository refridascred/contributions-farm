-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, active, region) VALUES (80, 43, 'latest');
INSERT INTO stats_logs (rank, active, region) VALUES (58, 78, 'staging');
INSERT INTO stats_logs (rank, active, region) VALUES (56, 42, 'local');
