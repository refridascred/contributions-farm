-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (score, ratio) VALUES (21.48, 76.52);
INSERT INTO stats_logs (score, ratio) VALUES (40.1, 92.57);
INSERT INTO stats_logs (score, ratio) VALUES (23.86, 36.24);
