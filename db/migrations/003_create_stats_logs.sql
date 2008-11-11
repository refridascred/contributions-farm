-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (region, ratio, rank) VALUES ('local', 82.13, 92);
INSERT INTO stats_logs (region, ratio, rank) VALUES ('eu-west', 45.42, 9);
