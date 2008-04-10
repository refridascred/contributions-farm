-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, ratio, score) VALUES (6, 45.63, 76.34);
INSERT INTO stats_logs (active, ratio, score) VALUES (85, 98.34, 91.15);
INSERT INTO stats_logs (active, ratio, score) VALUES (59, 52.03, 70.63);
