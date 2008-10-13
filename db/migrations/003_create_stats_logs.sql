-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (score, level, owner) VALUES (15.32, 96, 'cached');
INSERT INTO stats_logs (score, level, owner) VALUES (43.05, 92, 'local');
INSERT INTO stats_logs (score, level, owner) VALUES (45.43, 50, 'strict');
