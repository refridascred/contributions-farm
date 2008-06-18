-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (level, count, score, owner) VALUES (26, 89, 68.66, 'eu-west');
INSERT INTO stats_logs (level, count, score, owner) VALUES (68, 39, 75.06, 'blue');
INSERT INTO stats_logs (level, count, score, owner) VALUES (13, 76, 16.48, 'primary');
