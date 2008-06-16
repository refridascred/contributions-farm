-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (active, score, ratio, owner, region) VALUES (66, 46.77, 17.46, 'edge', 'eu-west');
INSERT INTO stats_logs (active, score, ratio, owner, region) VALUES (12, 62.76, 86.57, 'standard', 'strict');
