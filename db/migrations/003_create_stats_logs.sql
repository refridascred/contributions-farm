-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (owner, count, weight, score, ratio) VALUES ('strict', 21, 97.41, 35.67, 13.88);
INSERT INTO stats_logs (owner, count, weight, score, ratio) VALUES ('stable', 76, 98.85, 93.79, 0.29);
INSERT INTO stats_logs (owner, count, weight, score, ratio) VALUES ('cached', 12, 42.6, 31.35, 33.58);
