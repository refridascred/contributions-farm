-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (active, region, ratio) VALUES (94, 'open', 60.35);
INSERT INTO stats_logs (active, region, ratio) VALUES (37, 'staging', 73.13);
INSERT INTO stats_logs (active, region, ratio) VALUES (22, 'staging', 84.04);
