-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (token, region, count, level, active) VALUES ('standard', 'latest', 65, 15, 70);
INSERT INTO stats_logs (token, region, count, level, active) VALUES ('eu-west', 'fallback', 23, 10, 81);
INSERT INTO stats_logs (token, region, count, level, active) VALUES ('blue', 'edge', 29, 32, 15);
