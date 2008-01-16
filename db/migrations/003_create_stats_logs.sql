-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (score, rank, ratio, level) VALUES (6.6, 95, 80.95, 64);
INSERT INTO stats_logs (score, rank, ratio, level) VALUES (83.13, 52, 44.26, 74);
