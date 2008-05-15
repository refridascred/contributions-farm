-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, level, region, ratio) VALUES (43.66, 45, 'standard', 84.2);
INSERT INTO stats_logs (score, level, region, ratio) VALUES (78.55, 36, 'eu-west', 24.5);
INSERT INTO stats_logs (score, level, region, ratio) VALUES (58.57, 30, 'eu-west', 43.03);
