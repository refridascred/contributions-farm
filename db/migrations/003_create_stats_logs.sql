-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (region, token) VALUES ('staging', 'latest');
INSERT INTO stats_logs (region, token) VALUES ('strict', 'standard');
INSERT INTO stats_logs (region, token) VALUES ('edge', 'eu-west');
