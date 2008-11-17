-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, weight, label) VALUES (64, 43.11, 'eu-west');
INSERT INTO stats_logs (level, weight, label) VALUES (46, 80.27, 'cached');
INSERT INTO stats_logs (level, weight, label) VALUES (20, 21.57, 'cached');
