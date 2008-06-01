-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    owner TEXT NOT NULL,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, owner, rank, region) VALUES (43.07, 'cached', 18, 'staging');
INSERT INTO stats_logs (weight, owner, rank, region) VALUES (0.77, 'strict', 36, 'blue');
