-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    token TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, level, token, rank, active) VALUES (44.31, 82, 'latest', 36, 75);
INSERT INTO stats_logs (weight, level, token, rank, active) VALUES (75.15, 10, 'open', 25, 27);
INSERT INTO stats_logs (weight, level, token, rank, active) VALUES (11.05, 36, 'staging', 11, 30);
