-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (count, region, rank) VALUES (86, 'eu-west', 83);
INSERT INTO stats_logs (count, region, rank) VALUES (90, 'primary', 20);
INSERT INTO stats_logs (count, region, rank) VALUES (70, 'green', 91);
