-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (score, weight, ratio) VALUES (49.52, 37.68, 98.72);
INSERT INTO stats_logs (score, weight, ratio) VALUES (90.26, 30.63, 66.31);
INSERT INTO stats_logs (score, weight, ratio) VALUES (29.17, 3.1, 32.54);
