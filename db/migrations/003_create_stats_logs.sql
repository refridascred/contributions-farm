-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (rank, ratio, region, count) VALUES (8, 91.78, 'blue', 69);
INSERT INTO stats_logs (rank, ratio, region, count) VALUES (20, 38.92, 'staging', 3);
INSERT INTO stats_logs (rank, ratio, region, count) VALUES (18, 55.7, 'staging', 27);
