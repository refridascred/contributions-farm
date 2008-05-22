-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (rank, active, weight, level, token) VALUES (9, 28, 28.74, 70, 'strict');
INSERT INTO stats_logs (rank, active, weight, level, token) VALUES (46, 25, 10.35, 2, 'stable');
INSERT INTO stats_logs (rank, active, weight, level, token) VALUES (38, 39, 67.07, 96, 'staging');
