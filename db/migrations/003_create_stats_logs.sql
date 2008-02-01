-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (active, label, weight, state, level) VALUES (86, 'cached', 10.28, 'strict', 75);
INSERT INTO stats_logs (active, label, weight, state, level) VALUES (18, 'eu-west', 20.73, 'strict', 67);
INSERT INTO stats_logs (active, label, weight, state, level) VALUES (83, 'open', 37.26, 'latest', 97);
