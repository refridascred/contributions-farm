-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (token, level, active, region) VALUES ('blue', 93, 11, 'edge');
INSERT INTO stats_logs (token, level, active, region) VALUES ('edge', 11, 32, 'cached');
