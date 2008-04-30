-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, ratio, count, level) VALUES (71.27, 63.93, 9, 65);
INSERT INTO stats_logs (score, ratio, count, level) VALUES (92.39, 37.08, 72, 81);
