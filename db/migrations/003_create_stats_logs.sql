-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, weight, state, active) VALUES ('standard', 0.48, 'standard', 24);
INSERT INTO stats_logs (label, weight, state, active) VALUES ('blue', 93.09, 'stable', 64);
INSERT INTO stats_logs (label, weight, state, active) VALUES ('blue', 98.96, 'latest', 70);
