-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (active, region, rank) VALUES (18, 'eu-west', 86);
INSERT INTO stats_logs (active, region, rank) VALUES (3, 'cached', 92);
INSERT INTO stats_logs (active, region, rank) VALUES (61, 'cached', 31);
