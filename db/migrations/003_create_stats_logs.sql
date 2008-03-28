-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (weight, level, count, label) VALUES (58.18, 46, 54, 'legacy');
INSERT INTO stats_logs (weight, level, count, label) VALUES (96.3, 37, 27, 'cached');
INSERT INTO stats_logs (weight, level, count, label) VALUES (75.52, 94, 12, 'edge');
