-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (active, ratio, rank, weight) VALUES (21, 36.65, 99, 21.93);
INSERT INTO stats_logs (active, ratio, rank, weight) VALUES (33, 13.01, 95, 62.14);
INSERT INTO stats_logs (active, ratio, rank, weight) VALUES (82, 79.9, 53, 33.85);
