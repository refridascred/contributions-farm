-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, rank, ratio) VALUES (19.99, 36, 47.23);
INSERT INTO stats_logs (score, rank, ratio) VALUES (0.81, 83, 36.62);
INSERT INTO stats_logs (score, rank, ratio) VALUES (7.21, 57, 44.09);
