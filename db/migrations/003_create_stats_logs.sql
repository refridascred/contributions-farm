-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (ratio, active, token, region) VALUES (27.89, 91, 'edge', 'edge');
INSERT INTO stats_logs (ratio, active, token, region) VALUES (6.37, 52, 'primary', 'fallback');
