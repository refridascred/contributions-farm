-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, owner, count) VALUES (61.76, 'latest', 58);
INSERT INTO stats_logs (ratio, owner, count) VALUES (66.36, 'local', 55);
INSERT INTO stats_logs (ratio, owner, count) VALUES (57.68, 'edge', 39);
