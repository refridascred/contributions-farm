-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, count, label, owner) VALUES (73.87, 58, 'edge', 'blue');
INSERT INTO stats_logs (ratio, count, label, owner) VALUES (81.23, 67, 'open', 'open');
INSERT INTO stats_logs (ratio, count, label, owner) VALUES (19.09, 2, 'legacy', 'open');
