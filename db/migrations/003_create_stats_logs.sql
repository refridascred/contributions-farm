-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (rank, ratio, score) VALUES (9, 32.43, 3.38);
INSERT INTO stats_logs (rank, ratio, score) VALUES (44, 54.71, 97.12);
INSERT INTO stats_logs (rank, ratio, score) VALUES (15, 53.27, 12.72);
