-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (weight, active, rank) VALUES (74.01, 36, 13);
INSERT INTO stats_logs (weight, active, rank) VALUES (81.63, 2, 56);
INSERT INTO stats_logs (weight, active, rank) VALUES (2.41, 90, 5);
