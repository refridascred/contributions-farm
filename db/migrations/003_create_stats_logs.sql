-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (region, ratio, owner, token) VALUES ('stable', 91.59, 'edge', 'legacy');
INSERT INTO stats_logs (region, ratio, owner, token) VALUES ('stable', 49.43, 'standard', 'edge');
