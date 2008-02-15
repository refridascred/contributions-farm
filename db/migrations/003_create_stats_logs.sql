-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (count, level, score, region) VALUES (77, 73, 77.84, 'local');
INSERT INTO stats_logs (count, level, score, region) VALUES (53, 19, 73.98, 'eu-west');
INSERT INTO stats_logs (count, level, score, region) VALUES (33, 36, 32.75, 'green');
