-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (weight, level) VALUES (53.91, 93);
INSERT INTO stats_logs (weight, level) VALUES (13.42, 16);
INSERT INTO stats_logs (weight, level) VALUES (7.49, 34);
