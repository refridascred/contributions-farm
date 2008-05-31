-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, label, token, rank) VALUES (30.11, 'latest', 'green', 66);
INSERT INTO stats_logs (ratio, label, token, rank) VALUES (58.72, 'edge', 'local', 75);
INSERT INTO stats_logs (ratio, label, token, rank) VALUES (62.06, 'edge', 'latest', 69);
