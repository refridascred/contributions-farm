-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, region, score, ratio, weight) VALUES (30, 'primary', 69.09, 81.64, 73.91);
INSERT INTO stats_logs (count, region, score, ratio, weight) VALUES (41, 'cached', 88.75, 27.16, 70.59);
