-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (region, label, active, ratio) VALUES ('local', 'eu-west', 43, 67.65);
INSERT INTO stats_logs (region, label, active, ratio) VALUES ('blue', 'edge', 89, 11.9);
INSERT INTO stats_logs (region, label, active, ratio) VALUES ('fallback', 'cached', 70, 79.28);
