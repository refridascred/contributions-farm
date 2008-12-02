-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (count, ratio, active, owner, region) VALUES (78, 65.47, 40, 'standard', 'stable');
INSERT INTO stats_logs (count, ratio, active, owner, region) VALUES (92, 75.96, 51, 'legacy', 'local');
INSERT INTO stats_logs (count, ratio, active, owner, region) VALUES (77, 79.77, 30, 'latest', 'edge');
