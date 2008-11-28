-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (level, score, ratio) VALUES (81, 52.51, 84.72);
INSERT INTO stats_logs (level, score, ratio) VALUES (27, 43.88, 37.74);
INSERT INTO stats_logs (level, score, ratio) VALUES (36, 81.82, 58.89);
