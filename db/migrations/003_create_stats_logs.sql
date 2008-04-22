-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (state, active, label, level, score) VALUES ('edge', 60, 'eu-west', 98, 0.67);
INSERT INTO stats_logs (state, active, label, level, score) VALUES ('stable', 41, 'primary', 32, 89.4);
INSERT INTO stats_logs (state, active, label, level, score) VALUES ('blue', 6, 'stable', 34, 96.83);
