-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (level, token, weight, region) VALUES (64, 'blue', 48.77, 'legacy');
INSERT INTO stats_logs (level, token, weight, region) VALUES (38, 'local', 0.91, 'legacy');
INSERT INTO stats_logs (level, token, weight, region) VALUES (48, 'open', 82.37, 'fallback');
