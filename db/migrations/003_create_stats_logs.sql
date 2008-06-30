-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (rank, ratio, score, level) VALUES (1, 15.24, 61.26, 74);
INSERT INTO stats_logs (rank, ratio, score, level) VALUES (33, 36.93, 18.13, 62);
INSERT INTO stats_logs (rank, ratio, score, level) VALUES (85, 6.55, 77.09, 81);
