-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (ratio, state, label, score, active) VALUES (32.79, 'fallback', 'green', 96.2, 80);
INSERT INTO stats_logs (ratio, state, label, score, active) VALUES (87.26, 'latest', 'staging', 54.36, 57);
INSERT INTO stats_logs (ratio, state, label, score, active) VALUES (42.12, 'standard', 'strict', 85.53, 33);
