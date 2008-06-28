-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (region, count, score, token) VALUES ('open', 4, 81.5, 'latest');
INSERT INTO stats_logs (region, count, score, token) VALUES ('legacy', 40, 11.28, 'green');
INSERT INTO stats_logs (region, count, score, token) VALUES ('legacy', 32, 0.49, 'stable');
