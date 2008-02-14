-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (count, active, weight) VALUES (33, 75, 74.86);
INSERT INTO stats_logs (count, active, weight) VALUES (94, 94, 55.83);
INSERT INTO stats_logs (count, active, weight) VALUES (9, 56, 15.92);
