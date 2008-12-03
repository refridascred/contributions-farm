-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (weight, count, label, active, owner) VALUES (82.49, 66, 'strict', 52, 'fallback');
INSERT INTO stats_logs (weight, count, label, active, owner) VALUES (73.09, 72, 'cached', 69, 'primary');
INSERT INTO stats_logs (weight, count, label, active, owner) VALUES (64.03, 39, 'green', 84, 'blue');
