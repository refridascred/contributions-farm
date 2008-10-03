-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (score, level, count, owner) VALUES (43.27, 70, 84, 'green');
INSERT INTO stats_logs (score, level, count, owner) VALUES (84.69, 4, 61, 'fallback');
INSERT INTO stats_logs (score, level, count, owner) VALUES (54.39, 71, 99, 'open');
