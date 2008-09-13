-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (weight, label, level, state, active) VALUES (69.08, 'strict', 80, 'open', 1);
INSERT INTO stats_logs (weight, label, level, state, active) VALUES (7.22, 'stable', 7, 'fallback', 66);
INSERT INTO stats_logs (weight, label, level, state, active) VALUES (18.68, 'eu-west', 18, 'eu-west', 93);
