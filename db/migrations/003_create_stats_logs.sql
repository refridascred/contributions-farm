-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (score, weight, owner) VALUES (1.63, 43.08, 'strict');
INSERT INTO stats_logs (score, weight, owner) VALUES (78.85, 47.72, 'stable');
