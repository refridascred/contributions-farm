-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (token, level, weight, label) VALUES ('fallback', 21, 82.67, 'edge');
INSERT INTO stats_logs (token, level, weight, label) VALUES ('legacy', 7, 46.68, 'primary');
