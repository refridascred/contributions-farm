-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (score, level, weight, label) VALUES (36.12, 84, 30.61, 'green');
INSERT INTO stats_logs (score, level, weight, label) VALUES (98.74, 73, 44.6, 'primary');
INSERT INTO stats_logs (score, level, weight, label) VALUES (68.14, 51, 56.84, 'staging');
