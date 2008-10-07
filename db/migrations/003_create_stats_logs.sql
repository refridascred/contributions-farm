-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, level, weight) VALUES (91.21, 68, 4.7);
INSERT INTO stats_logs (score, level, weight) VALUES (30.71, 40, 59.38);
INSERT INTO stats_logs (score, level, weight) VALUES (82.24, 49, 74.66);
