-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (ratio, count, token, region, score) VALUES (12.1, 45, 'primary', 'stable', 39.54);
INSERT INTO stats_logs (ratio, count, token, region, score) VALUES (52.05, 15, 'eu-west', 'legacy', 54.55);
INSERT INTO stats_logs (ratio, count, token, region, score) VALUES (7.84, 76, 'strict', 'standard', 0.48);
