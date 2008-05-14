-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (count, rank, score, token, region) VALUES (73, 93, 91.07, 'latest', 'open');
INSERT INTO stats_logs (count, rank, score, token, region) VALUES (69, 26, 53.28, 'fallback', 'open');
INSERT INTO stats_logs (count, rank, score, token, region) VALUES (75, 26, 69.21, 'edge', 'staging');
