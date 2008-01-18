-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (active, label, ratio) VALUES (64, 'latest', 36.38);
INSERT INTO stats_logs (active, label, ratio) VALUES (32, 'green', 65.28);
INSERT INTO stats_logs (active, label, ratio) VALUES (9, 'cached', 47.99);
