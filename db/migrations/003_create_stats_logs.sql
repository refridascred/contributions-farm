-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, rank, label, token) VALUES (18.06, 17, 'stable', 'fallback');
INSERT INTO stats_logs (ratio, rank, label, token) VALUES (64.5, 45, 'blue', 'latest');
