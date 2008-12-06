-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, weight, state, label) VALUES (27, 27.88, 'staging', 'stable');
INSERT INTO stats_logs (active, weight, state, label) VALUES (34, 38.99, 'green', 'blue');
INSERT INTO stats_logs (active, weight, state, label) VALUES (39, 87.86, 'cached', 'fallback');
