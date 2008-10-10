-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    rank INTEGER,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (ratio, weight, rank, owner, label) VALUES (9.96, 12.24, 96, 'green', 'staging');
INSERT INTO stats_logs (ratio, weight, rank, owner, label) VALUES (67.21, 20.72, 87, 'primary', 'staging');
