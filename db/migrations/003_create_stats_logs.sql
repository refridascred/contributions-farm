-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, score) VALUES (76.13, 44.55);
INSERT INTO stats_logs (weight, score) VALUES (80.45, 28.43);
INSERT INTO stats_logs (weight, score) VALUES (8.55, 98.28);
