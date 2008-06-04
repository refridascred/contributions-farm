-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    token TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, level, token, owner, score) VALUES (80, 75, 'fallback', 'latest', 2.24);
INSERT INTO stats_logs (count, level, token, owner, score) VALUES (52, 72, 'legacy', 'open', 89.46);
INSERT INTO stats_logs (count, level, token, owner, score) VALUES (32, 24, 'open', 'standard', 83.83);
