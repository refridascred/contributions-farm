-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (weight, active, state, level) VALUES (84.5, 77, 'blue', 51);
INSERT INTO stats_logs (weight, active, state, level) VALUES (36.75, 15, 'blue', 36);
