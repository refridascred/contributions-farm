-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (active, token, level, score, owner) VALUES (17, 'cached', 25, 40.46, 'strict');
INSERT INTO stats_logs (active, token, level, score, owner) VALUES (65, 'standard', 84, 5.03, 'staging');
