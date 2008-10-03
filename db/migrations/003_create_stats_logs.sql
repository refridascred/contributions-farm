-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (weight, state, label, level) VALUES (16.15, 'edge', 'blue', 49);
INSERT INTO stats_logs (weight, state, label, level) VALUES (1.78, 'stable', 'edge', 79);
INSERT INTO stats_logs (weight, state, label, level) VALUES (53.9, 'eu-west', 'edge', 93);
