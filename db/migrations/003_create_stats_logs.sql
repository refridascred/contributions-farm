-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (region, ratio, active, score, level) VALUES ('blue', 25.13, 33, 55.16, 59);
INSERT INTO stats_logs (region, ratio, active, score, level) VALUES ('staging', 39.69, 73, 83.18, 44);
