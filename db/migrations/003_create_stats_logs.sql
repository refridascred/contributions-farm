-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (score, ratio) VALUES (19.53, 83.86);
INSERT INTO stats_logs (score, ratio) VALUES (86.54, 51.3);
INSERT INTO stats_logs (score, ratio) VALUES (69.89, 84.29);
