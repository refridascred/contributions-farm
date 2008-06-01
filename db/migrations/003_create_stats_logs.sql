-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, region, rank) VALUES (18.47, 'latest', 33);
INSERT INTO stats_logs (ratio, region, rank) VALUES (57.85, 'eu-west', 64);
