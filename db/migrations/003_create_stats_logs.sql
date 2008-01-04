-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (region, token, level, weight) VALUES ('green', 'staging', 73, 2.96);
INSERT INTO stats_logs (region, token, level, weight) VALUES ('primary', 'open', 4, 30.01);
INSERT INTO stats_logs (region, token, level, weight) VALUES ('standard', 'legacy', 11, 0.21);
