-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, region, active) VALUES (55.18, 'green', 57);
INSERT INTO stats_logs (ratio, region, active) VALUES (22.03, 'latest', 7);
INSERT INTO stats_logs (ratio, region, active) VALUES (55.49, 'edge', 10);
