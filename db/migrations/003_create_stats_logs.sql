-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, weight, region, token, owner) VALUES (13, 24.67, 'standard', 'staging', 'primary');
INSERT INTO stats_logs (count, weight, region, token, owner) VALUES (39, 81.41, 'primary', 'edge', 'strict');
