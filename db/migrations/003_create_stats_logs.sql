-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (weight, rank, active) VALUES (48.64, 24, 60);
INSERT INTO stats_logs (weight, rank, active) VALUES (50.38, 68, 77);
INSERT INTO stats_logs (weight, rank, active) VALUES (2.61, 44, 58);
