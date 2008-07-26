-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, token) VALUES (72.21, 'open');
INSERT INTO stats_logs (ratio, token) VALUES (70.84, 'primary');
INSERT INTO stats_logs (ratio, token) VALUES (43.17, 'local');
