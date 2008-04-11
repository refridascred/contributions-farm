-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (ratio, active) VALUES (4.73, 9);
INSERT INTO stats_logs (ratio, active) VALUES (51.78, 47);
INSERT INTO stats_logs (ratio, active) VALUES (36.85, 39);
