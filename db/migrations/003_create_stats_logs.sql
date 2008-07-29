-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (weight, token, active, region, score) VALUES (50.99, 'local', 65, 'primary', 86.54);
INSERT INTO stats_logs (weight, token, active, region, score) VALUES (90.77, 'eu-west', 55, 'strict', 21.15);
INSERT INTO stats_logs (weight, token, active, region, score) VALUES (10.57, 'stable', 17, 'staging', 25.67);
