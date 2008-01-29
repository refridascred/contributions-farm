-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (weight, label, ratio) VALUES (63.05, 'legacy', 0.99);
INSERT INTO stats_logs (weight, label, ratio) VALUES (27.42, 'latest', 22.71);
INSERT INTO stats_logs (weight, label, ratio) VALUES (79.92, 'local', 8.24);
