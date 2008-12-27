-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    rank INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (level, label, rank, ratio, score) VALUES (76, 'green', 53, 42.78, 73.0);
INSERT INTO stats_logs (level, label, rank, ratio, score) VALUES (86, 'standard', 55, 78.76, 78.9);
