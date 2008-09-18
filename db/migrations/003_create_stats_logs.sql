-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (active, rank, score, level, weight) VALUES (94, 32, 10.82, 15, 97.8);
INSERT INTO stats_logs (active, rank, score, level, weight) VALUES (19, 98, 4.57, 32, 5.26);
