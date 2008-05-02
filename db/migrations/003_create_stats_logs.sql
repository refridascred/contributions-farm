-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (level, score, weight, rank, active) VALUES (69, 52.0, 90.37, 48, 39);
INSERT INTO stats_logs (level, score, weight, rank, active) VALUES (73, 96.45, 95.89, 96, 19);
