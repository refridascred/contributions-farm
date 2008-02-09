-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    ratio REAL,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (count, ratio, region, token) VALUES (39, 38.5, 'latest', 'blue');
INSERT INTO stats_logs (count, ratio, region, token) VALUES (78, 78.3, 'local', 'legacy');
INSERT INTO stats_logs (count, ratio, region, token) VALUES (61, 56.7, 'primary', 'open');
