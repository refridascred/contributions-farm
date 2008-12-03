-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (weight, state, level) VALUES (89.86, 'edge', 75);
INSERT INTO stats_logs (weight, state, level) VALUES (84.65, 'fallback', 97);
INSERT INTO stats_logs (weight, state, level) VALUES (83.85, 'strict', 15);
