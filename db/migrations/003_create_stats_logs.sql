-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (level, weight, rank, owner) VALUES (40, 43.47, 2, 'edge');
INSERT INTO stats_logs (level, weight, rank, owner) VALUES (3, 62.16, 65, 'stable');
INSERT INTO stats_logs (level, weight, rank, owner) VALUES (61, 77.55, 66, 'staging');
