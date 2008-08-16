-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (weight, rank, active, count) VALUES (98.23, 91, 13, 18);
INSERT INTO stats_logs (weight, rank, active, count) VALUES (19.5, 77, 67, 41);
