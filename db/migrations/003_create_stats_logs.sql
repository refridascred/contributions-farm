-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (score, weight, label, ratio) VALUES (32.44, 60.59, 'cached', 77.48);
INSERT INTO stats_logs (score, weight, label, ratio) VALUES (86.38, 96.3, 'eu-west', 72.92);
