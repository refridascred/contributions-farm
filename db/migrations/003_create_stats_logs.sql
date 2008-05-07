-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, state, weight, token) VALUES (84, 'staging', 71.61, 'blue');
INSERT INTO stats_logs (active, state, weight, token) VALUES (80, 'strict', 7.71, 'stable');
INSERT INTO stats_logs (active, state, weight, token) VALUES (66, 'fallback', 81.53, 'latest');
