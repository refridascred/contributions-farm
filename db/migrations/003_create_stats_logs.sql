-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (count, weight, rank) VALUES (77, 97.74, 59);
