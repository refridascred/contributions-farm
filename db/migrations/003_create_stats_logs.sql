-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, region, count, ratio) VALUES (10.32, 'open', 44, 47.56);
INSERT INTO stats_logs (score, region, count, ratio) VALUES (29.27, 'green', 72, 66.16);
INSERT INTO stats_logs (score, region, count, ratio) VALUES (29.84, 'standard', 62, 26.41);
