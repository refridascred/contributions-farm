-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, weight, level, label) VALUES (81, 46.19, 52, 'primary');
INSERT INTO stats_logs (count, weight, level, label) VALUES (8, 47.62, 11, 'local');
