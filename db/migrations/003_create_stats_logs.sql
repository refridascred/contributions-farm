-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (score, active, ratio, rank) VALUES (63.26, 93, 97.92, 38);
INSERT INTO stats_logs (score, active, ratio, rank) VALUES (97.63, 84, 7.9, 25);
INSERT INTO stats_logs (score, active, ratio, rank) VALUES (86.52, 30, 58.21, 16);
