-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (weight, level, label) VALUES (12.42, 46, 'open');
INSERT INTO stats_logs (weight, level, label) VALUES (52.7, 35, 'staging');
INSERT INTO stats_logs (weight, level, label) VALUES (67.25, 60, 'primary');
