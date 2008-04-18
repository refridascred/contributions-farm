-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (weight, count, region, score, ratio) VALUES (6.74, 64, 'primary', 75.41, 83.44);
INSERT INTO stats_logs (weight, count, region, score, ratio) VALUES (83.77, 59, 'green', 98.27, 15.24);
