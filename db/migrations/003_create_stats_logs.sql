-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (region, ratio, weight, score) VALUES ('primary', 33.83, 46.95, 4.34);
INSERT INTO stats_logs (region, ratio, weight, score) VALUES ('blue', 36.63, 37.32, 54.58);
