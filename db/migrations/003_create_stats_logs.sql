-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (rank, score, level, ratio) VALUES (53, 82.03, 96, 96.5);
INSERT INTO stats_logs (rank, score, level, ratio) VALUES (57, 43.39, 98, 2.94);
