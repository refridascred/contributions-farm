-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, weight, count) VALUES (9.04, 76.08, 3);
INSERT INTO stats_logs (score, weight, count) VALUES (27.05, 80.76, 47);
INSERT INTO stats_logs (score, weight, count) VALUES (91.19, 63.06, 74);
