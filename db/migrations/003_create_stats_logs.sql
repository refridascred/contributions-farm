-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (count, weight, score, level) VALUES (51, 78.38, 66.85, 51);
INSERT INTO stats_logs (count, weight, score, level) VALUES (32, 55.69, 74.09, 37);
INSERT INTO stats_logs (count, weight, score, level) VALUES (63, 5.45, 16.77, 70);
