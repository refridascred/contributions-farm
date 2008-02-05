-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, token, count, ratio) VALUES (96.6, 'primary', 72, 4.98);
INSERT INTO stats_logs (weight, token, count, ratio) VALUES (86.87, 'primary', 97, 90.55);
INSERT INTO stats_logs (weight, token, count, ratio) VALUES (87.41, 'legacy', 43, 66.69);
