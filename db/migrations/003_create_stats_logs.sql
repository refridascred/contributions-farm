-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (ratio, level, weight, label) VALUES (54.22, 79, 36.59, 'fallback');
INSERT INTO stats_logs (ratio, level, weight, label) VALUES (96.66, 7, 27.1, 'local');
