-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (region, label, ratio, active) VALUES ('blue', 'stable', 25.64, 65);
INSERT INTO stats_logs (region, label, ratio, active) VALUES ('cached', 'blue', 71.87, 45);
INSERT INTO stats_logs (region, label, ratio, active) VALUES ('eu-west', 'legacy', 1.0, 38);
