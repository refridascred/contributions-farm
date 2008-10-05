-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (weight, label, owner, ratio) VALUES (62.45, 'cached', 'local', 0.31);
INSERT INTO stats_logs (weight, label, owner, ratio) VALUES (7.66, 'local', 'stable', 62.18);
INSERT INTO stats_logs (weight, label, owner, ratio) VALUES (5.37, 'edge', 'green', 64.28);
