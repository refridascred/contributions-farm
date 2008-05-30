-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (score, weight, level, active) VALUES (38.31, 70.0, 97, 45);
INSERT INTO stats_logs (score, weight, level, active) VALUES (24.64, 36.54, 41, 58);
INSERT INTO stats_logs (score, weight, level, active) VALUES (33.97, 33.2, 16, 48);
