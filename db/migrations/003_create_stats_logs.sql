-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (count, score, active) VALUES (63, 32.17, 64);
INSERT INTO stats_logs (count, score, active) VALUES (84, 85.55, 23);
INSERT INTO stats_logs (count, score, active) VALUES (52, 29.57, 57);
