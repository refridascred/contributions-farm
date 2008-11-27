-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    rank INTEGER,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (count, level, rank, weight, token) VALUES (36, 82, 84, 31.61, 'primary');
INSERT INTO stats_logs (count, level, rank, weight, token) VALUES (69, 14, 2, 49.59, 'latest');
INSERT INTO stats_logs (count, level, rank, weight, token) VALUES (56, 78, 22, 77.11, 'local');
