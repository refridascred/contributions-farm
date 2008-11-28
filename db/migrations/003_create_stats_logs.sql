-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    level INTEGER,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (weight, level, rank, active) VALUES (38.01, 61, 3, 88);
INSERT INTO stats_logs (weight, level, rank, active) VALUES (12.47, 7, 99, 31);
INSERT INTO stats_logs (weight, level, rank, active) VALUES (17.22, 45, 63, 44);
