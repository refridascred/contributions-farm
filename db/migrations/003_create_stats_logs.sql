-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (level, label, weight, region) VALUES (15, 'fallback', 25.46, 'green');
INSERT INTO stats_logs (level, label, weight, region) VALUES (85, 'strict', 18.67, 'cached');
