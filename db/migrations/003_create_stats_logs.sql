-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (weight, active, count) VALUES (1.97, 14, 97);
INSERT INTO stats_logs (weight, active, count) VALUES (16.07, 94, 75);
INSERT INTO stats_logs (weight, active, count) VALUES (23.19, 20, 75);
