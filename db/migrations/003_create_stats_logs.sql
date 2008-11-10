-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (level, count, label, active, weight) VALUES (73, 59, 'strict', 28, 52.98);
INSERT INTO stats_logs (level, count, label, active, weight) VALUES (91, 57, 'eu-west', 81, 96.65);
