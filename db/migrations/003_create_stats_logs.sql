-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (active, region, rank, label) VALUES (65, 'primary', 43, 'latest');
INSERT INTO stats_logs (active, region, rank, label) VALUES (98, 'fallback', 81, 'fallback');
INSERT INTO stats_logs (active, region, rank, label) VALUES (55, 'blue', 28, 'standard');
