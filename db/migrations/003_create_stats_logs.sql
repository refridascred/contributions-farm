-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (weight, state, active, token) VALUES (80.65, 'blue', 3, 'latest');
INSERT INTO stats_logs (weight, state, active, token) VALUES (27.85, 'strict', 69, 'eu-west');
INSERT INTO stats_logs (weight, state, active, token) VALUES (5.0, 'open', 2, 'green');
