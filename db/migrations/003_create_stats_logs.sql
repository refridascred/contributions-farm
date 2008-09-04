-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (weight, region, level, count, token) VALUES (18.4, 'primary', 28, 19, 'standard');
INSERT INTO stats_logs (weight, region, level, count, token) VALUES (69.44, 'eu-west', 82, 28, 'blue');
INSERT INTO stats_logs (weight, region, level, count, token) VALUES (92.57, 'latest', 16, 80, 'eu-west');
