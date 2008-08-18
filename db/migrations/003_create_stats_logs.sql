-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (level, ratio, token) VALUES (87, 55.49, 'legacy');
INSERT INTO stats_logs (level, ratio, token) VALUES (56, 7.77, 'latest');
