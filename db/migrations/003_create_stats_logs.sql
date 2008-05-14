-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (label, rank, region) VALUES ('legacy', 52, 'local');
INSERT INTO stats_logs (label, rank, region) VALUES ('blue', 19, 'blue');
INSERT INTO stats_logs (label, rank, region) VALUES ('strict', 99, 'staging');
