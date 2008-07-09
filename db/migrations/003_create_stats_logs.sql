-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (level, count, weight, score, owner) VALUES (91, 94, 44.54, 54.75, 'blue');
INSERT INTO stats_logs (level, count, weight, score, owner) VALUES (14, 82, 52.74, 78.27, 'local');
INSERT INTO stats_logs (level, count, weight, score, owner) VALUES (68, 25, 14.23, 36.09, 'stable');
