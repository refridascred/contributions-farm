-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (rank, token, region) VALUES (42, 'standard', 'staging');
INSERT INTO stats_logs (rank, token, region) VALUES (30, 'cached', 'local');
INSERT INTO stats_logs (rank, token, region) VALUES (67, 'edge', 'edge');
