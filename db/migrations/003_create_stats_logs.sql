-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (rank, active, weight, level) VALUES (27, 67, 4.82, 59);
INSERT INTO stats_logs (rank, active, weight, level) VALUES (73, 53, 73.3, 51);
INSERT INTO stats_logs (rank, active, weight, level) VALUES (42, 84, 33.39, 38);
