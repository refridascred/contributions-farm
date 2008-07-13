-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, label, weight) VALUES (4, 'primary', 45.98);
INSERT INTO stats_logs (active, label, weight) VALUES (63, 'fallback', 59.62);
INSERT INTO stats_logs (active, label, weight) VALUES (84, 'standard', 36.61);
