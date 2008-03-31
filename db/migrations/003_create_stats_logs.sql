-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (level, weight, score, rank, ratio) VALUES (70, 37.11, 14.09, 92, 98.72);
INSERT INTO stats_logs (level, weight, score, rank, ratio) VALUES (71, 67.06, 40.09, 3, 15.27);
