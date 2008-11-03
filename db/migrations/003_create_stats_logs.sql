-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (ratio, active, level) VALUES (10.18, 52, 97);
INSERT INTO stats_logs (ratio, active, level) VALUES (1.12, 8, 61);
INSERT INTO stats_logs (ratio, active, level) VALUES (65.86, 32, 91);
