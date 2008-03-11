-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, region, rank) VALUES (82, 'eu-west', 36);
INSERT INTO stats_logs (count, region, rank) VALUES (74, 'standard', 33);
INSERT INTO stats_logs (count, region, rank) VALUES (76, 'stable', 67);
