-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, rank, owner) VALUES (85.84, 50, 'local');
INSERT INTO stats_logs (weight, rank, owner) VALUES (1.76, 60, 'fallback');
INSERT INTO stats_logs (weight, rank, owner) VALUES (6.21, 63, 'primary');
