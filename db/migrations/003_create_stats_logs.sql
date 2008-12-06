-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (rank, region, token) VALUES (18, 'legacy', 'latest');
INSERT INTO stats_logs (rank, region, token) VALUES (33, 'primary', 'stable');
