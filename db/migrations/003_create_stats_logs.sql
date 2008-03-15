-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (count, weight, score, ratio) VALUES (40, 82.98, 71.41, 27.57);
INSERT INTO stats_logs (count, weight, score, ratio) VALUES (15, 8.14, 83.68, 71.48);
INSERT INTO stats_logs (count, weight, score, ratio) VALUES (98, 36.87, 96.42, 15.11);
