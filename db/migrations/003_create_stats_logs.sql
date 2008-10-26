-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (level, score, weight, owner, active) VALUES (73, 85.84, 53.0, 'green', 55);
INSERT INTO stats_logs (level, score, weight, owner, active) VALUES (7, 15.12, 54.81, 'standard', 92);
INSERT INTO stats_logs (level, score, weight, owner, active) VALUES (17, 5.04, 57.99, 'local', 47);
