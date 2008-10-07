-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (rank, score, region) VALUES (30, 92.57, 'stable');
INSERT INTO stats_logs (rank, score, region) VALUES (44, 16.41, 'standard');
INSERT INTO stats_logs (rank, score, region) VALUES (37, 54.78, 'eu-west');
