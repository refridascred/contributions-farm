-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, token) VALUES (74.71, 'staging');
INSERT INTO stats_logs (ratio, token) VALUES (77.43, 'staging');
INSERT INTO stats_logs (ratio, token) VALUES (59.51, 'blue');
