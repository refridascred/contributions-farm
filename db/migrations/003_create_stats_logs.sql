-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (weight, level, rank, score, ratio) VALUES (7.12, 22, 84, 52.88, 85.36);
INSERT INTO stats_logs (weight, level, rank, score, ratio) VALUES (10.5, 59, 73, 6.08, 7.63);
