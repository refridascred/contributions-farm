-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (rank, label) VALUES (58, 'eu-west');
INSERT INTO stats_logs (rank, label) VALUES (33, 'edge');
INSERT INTO stats_logs (rank, label) VALUES (51, 'local');
