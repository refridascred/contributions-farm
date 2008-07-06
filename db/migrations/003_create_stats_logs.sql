-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (level, weight, state, label) VALUES (93, 7.14, 'green', 'edge');
INSERT INTO stats_logs (level, weight, state, label) VALUES (95, 64.69, 'eu-west', 'standard');
INSERT INTO stats_logs (level, weight, state, label) VALUES (27, 91.96, 'edge', 'local');
