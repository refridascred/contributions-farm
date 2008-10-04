-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (score, ratio, level) VALUES (19.56, 5.86, 17);
INSERT INTO stats_logs (score, ratio, level) VALUES (41.0, 27.21, 13);
INSERT INTO stats_logs (score, ratio, level) VALUES (47.03, 33.13, 83);
