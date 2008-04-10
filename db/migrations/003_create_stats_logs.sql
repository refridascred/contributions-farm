-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    rank INTEGER,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (label, ratio, rank, level) VALUES ('standard', 35.64, 5, 10);
INSERT INTO stats_logs (label, ratio, rank, level) VALUES ('blue', 56.47, 14, 95);
INSERT INTO stats_logs (label, ratio, rank, level) VALUES ('edge', 64.96, 23, 81);
