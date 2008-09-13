-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (score, rank, region) VALUES (40.73, 18, 'edge');
INSERT INTO stats_logs (score, rank, region) VALUES (37.7, 33, 'eu-west');
INSERT INTO stats_logs (score, rank, region) VALUES (13.26, 64, 'local');
