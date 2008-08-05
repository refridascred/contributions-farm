-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (count, active, token, score, weight) VALUES (13, 2, 'edge', 39.37, 15.37);
INSERT INTO stats_logs (count, active, token, score, weight) VALUES (57, 4, 'stable', 92.71, 42.84);
INSERT INTO stats_logs (count, active, token, score, weight) VALUES (11, 96, 'latest', 90.91, 23.63);
