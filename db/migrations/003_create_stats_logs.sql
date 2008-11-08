-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (token, level, weight, owner) VALUES ('standard', 7, 88.55, 'standard');
INSERT INTO stats_logs (token, level, weight, owner) VALUES ('fallback', 90, 28.75, 'local');
INSERT INTO stats_logs (token, level, weight, owner) VALUES ('cached', 30, 75.12, 'edge');
