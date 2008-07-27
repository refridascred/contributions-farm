-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, score, state) VALUES (15, 88.07, 'local');
INSERT INTO stats_logs (level, score, state) VALUES (54, 35.17, 'strict');
INSERT INTO stats_logs (level, score, state) VALUES (18, 46.04, 'standard');
