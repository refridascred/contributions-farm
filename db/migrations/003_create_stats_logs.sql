-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, count, owner, active) VALUES (58.87, 81, 'local', 79);
INSERT INTO stats_logs (weight, count, owner, active) VALUES (39.25, 68, 'primary', 96);
INSERT INTO stats_logs (weight, count, owner, active) VALUES (46.28, 80, 'stable', 6);
