-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    ratio REAL,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (level, ratio, weight, label) VALUES (97, 71.69, 50.11, 'cached');
INSERT INTO stats_logs (level, ratio, weight, label) VALUES (82, 23.28, 11.42, 'local');
