-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (weight, ratio) VALUES (31.69, 62.69);
INSERT INTO stats_logs (weight, ratio) VALUES (0.96, 4.64);
INSERT INTO stats_logs (weight, ratio) VALUES (36.94, 14.64);
