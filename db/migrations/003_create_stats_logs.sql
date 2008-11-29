-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, owner, level, weight, score) VALUES ('edge', 'fallback', 57, 36.17, 64.87);
INSERT INTO stats_logs (token, owner, level, weight, score) VALUES ('standard', 'fallback', 94, 41.43, 32.69);
INSERT INTO stats_logs (token, owner, level, weight, score) VALUES ('staging', 'stable', 99, 57.31, 71.13);
