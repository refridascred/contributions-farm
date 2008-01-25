-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (active, weight, score, owner, count) VALUES (73, 93.34, 36.59, 'green', 56);
INSERT INTO stats_logs (active, weight, score, owner, count) VALUES (34, 36.34, 64.42, 'latest', 29);
INSERT INTO stats_logs (active, weight, score, owner, count) VALUES (82, 15.36, 55.97, 'standard', 74);
