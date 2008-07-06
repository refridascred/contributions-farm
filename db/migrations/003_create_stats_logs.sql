-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (count, score, level, region) VALUES (42, 61.74, 3, 'blue');
INSERT INTO stats_logs (count, score, level, region) VALUES (65, 58.96, 77, 'open');
INSERT INTO stats_logs (count, score, level, region) VALUES (27, 97.42, 48, 'stable');
