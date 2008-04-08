-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (level, token, owner, score, active) VALUES (4, 'fallback', 'open', 40.57, 51);
INSERT INTO stats_logs (level, token, owner, score, active) VALUES (98, 'local', 'primary', 49.47, 40);
