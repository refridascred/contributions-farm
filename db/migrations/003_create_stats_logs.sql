-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (ratio, region, count) VALUES (21.7, 'open', 91);
INSERT INTO stats_logs (ratio, region, count) VALUES (47.1, 'latest', 75);
INSERT INTO stats_logs (ratio, region, count) VALUES (78.48, 'blue', 13);
