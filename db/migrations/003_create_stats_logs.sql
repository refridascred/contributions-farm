-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (score, rank, ratio, level) VALUES (75.7, 45, 61.55, 9);
INSERT INTO stats_logs (score, rank, ratio, level) VALUES (77.27, 18, 93.98, 75);
INSERT INTO stats_logs (score, rank, ratio, level) VALUES (13.52, 41, 51.17, 57);
