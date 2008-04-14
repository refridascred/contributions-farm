-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, weight, token, active, count) VALUES ('standard', 54.9, 'eu-west', 51, 10);
INSERT INTO stats_logs (region, weight, token, active, count) VALUES ('legacy', 78.5, 'staging', 95, 16);
INSERT INTO stats_logs (region, weight, token, active, count) VALUES ('stable', 41.07, 'edge', 80, 30);
