-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (rank, token, region) VALUES (44, 'staging', 'standard');
INSERT INTO stats_logs (rank, token, region) VALUES (16, 'primary', 'stable');
INSERT INTO stats_logs (rank, token, region) VALUES (82, 'fallback', 'blue');
