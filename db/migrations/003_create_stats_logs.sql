-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    token TEXT,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (label, rank, token, weight, ratio) VALUES ('blue', 28, 'staging', 88.58, 89.45);
INSERT INTO stats_logs (label, rank, token, weight, ratio) VALUES ('staging', 8, 'legacy', 46.58, 94.2);
