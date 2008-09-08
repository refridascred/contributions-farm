-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (weight, active, score) VALUES (76.79, 54, 31.31);
INSERT INTO stats_logs (weight, active, score) VALUES (21.93, 46, 9.46);
INSERT INTO stats_logs (weight, active, score) VALUES (75.12, 24, 90.59);
