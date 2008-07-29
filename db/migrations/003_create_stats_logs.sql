-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    label TEXT,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (active, weight, label, region, state) VALUES (30, 57.66, 'primary', 'strict', 'staging');
INSERT INTO stats_logs (active, weight, label, region, state) VALUES (12, 90.76, 'fallback', 'open', 'stable');
INSERT INTO stats_logs (active, weight, label, region, state) VALUES (95, 77.2, 'latest', 'open', 'open');
