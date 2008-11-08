-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (active, level, score) VALUES (66, 33, 57.12);
INSERT INTO stats_logs (active, level, score) VALUES (11, 25, 24.89);
INSERT INTO stats_logs (active, level, score) VALUES (33, 78, 80.2);
