-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (score, ratio, active) VALUES (19.22, 77.88, 5);
INSERT INTO stats_logs (score, ratio, active) VALUES (34.55, 6.98, 31);
INSERT INTO stats_logs (score, ratio, active) VALUES (16.54, 45.51, 13);
