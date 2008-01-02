-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (active, region, count, label) VALUES (59, 'standard', 18, 'blue');
INSERT INTO stats_logs (active, region, count, label) VALUES (86, 'fallback', 84, 'green');
INSERT INTO stats_logs (active, region, count, label) VALUES (34, 'standard', 35, 'fallback');
