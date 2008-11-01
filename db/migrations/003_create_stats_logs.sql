-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, token, count, active, region) VALUES (25.64, 'stable', 80, 78, 'staging');
INSERT INTO stats_logs (ratio, token, count, active, region) VALUES (86.22, 'edge', 52, 29, 'legacy');
