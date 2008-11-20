-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (weight, ratio, score, level) VALUES (58.2, 42.86, 68.54, 72);
INSERT INTO stats_logs (weight, ratio, score, level) VALUES (9.72, 96.48, 20.57, 27);
INSERT INTO stats_logs (weight, ratio, score, level) VALUES (60.4, 98.54, 2.08, 24);
