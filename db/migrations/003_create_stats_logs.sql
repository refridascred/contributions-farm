-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    created_at TIMESTAMP,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (score, level, rank, ratio) VALUES (20.9, 9, 38, 13.3);
INSERT INTO stats_logs (score, level, rank, ratio) VALUES (66.84, 8, 94, 95.95);
