-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (rank, region, ratio, weight) VALUES (32, 'local', 89.87, 88.26);
INSERT INTO stats_logs (rank, region, ratio, weight) VALUES (43, 'eu-west', 14.95, 54.33);
