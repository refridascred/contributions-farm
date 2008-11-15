-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (weight, active, label, ratio) VALUES (45.86, 26, 'legacy', 34.29);
INSERT INTO stats_logs (weight, active, label, ratio) VALUES (32.86, 55, 'standard', 32.15);
INSERT INTO stats_logs (weight, active, label, ratio) VALUES (75.98, 94, 'latest', 51.48);
