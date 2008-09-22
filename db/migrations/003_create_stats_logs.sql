-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (state, level, score, ratio, active) VALUES ('staging', 15, 25.8, 32.62, 42);
INSERT INTO stats_logs (state, level, score, ratio, active) VALUES ('stable', 61, 60.51, 69.79, 57);
INSERT INTO stats_logs (state, level, score, ratio, active) VALUES ('edge', 74, 10.53, 6.03, 14);
