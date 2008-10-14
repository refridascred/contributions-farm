-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, score, rank, ratio) VALUES (87, 45.24, 31, 74.06);
INSERT INTO stats_logs (level, score, rank, ratio) VALUES (69, 77.06, 99, 77.86);
