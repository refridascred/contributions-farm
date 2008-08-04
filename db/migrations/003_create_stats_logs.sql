-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (level, ratio, score) VALUES (31, 38.39, 43.01);
INSERT INTO stats_logs (level, ratio, score) VALUES (95, 46.61, 59.77);
INSERT INTO stats_logs (level, ratio, score) VALUES (54, 4.98, 71.12);
