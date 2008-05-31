-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (level, score, owner, state) VALUES (19, 70.47, 'staging', 'blue');
INSERT INTO stats_logs (level, score, owner, state) VALUES (28, 86.17, 'staging', 'staging');
INSERT INTO stats_logs (level, score, owner, state) VALUES (52, 63.78, 'green', 'strict');
