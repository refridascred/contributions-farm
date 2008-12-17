-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (token, weight, score, level, rank) VALUES ('strict', 95.18, 15.23, 81, 7);
INSERT INTO stats_logs (token, weight, score, level, rank) VALUES ('fallback', 61.95, 94.65, 17, 67);
