-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    region TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (token, region, ratio, active) VALUES ('blue', 'edge', 49.14, 22);
INSERT INTO stats_logs (token, region, ratio, active) VALUES ('legacy', 'latest', 71.77, 49);
INSERT INTO stats_logs (token, region, ratio, active) VALUES ('standard', 'fallback', 72.87, 54);
