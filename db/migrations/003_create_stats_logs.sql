-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (region, weight, score, rank, active) VALUES ('legacy', 25.64, 73.96, 11, 54);
INSERT INTO stats_logs (region, weight, score, rank, active) VALUES ('edge', 64.42, 65.65, 28, 54);
