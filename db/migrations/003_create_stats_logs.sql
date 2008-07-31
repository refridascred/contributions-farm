-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (rank, region, score, weight) VALUES (86, 'eu-west', 98.31, 26.67);
INSERT INTO stats_logs (rank, region, score, weight) VALUES (31, 'green', 20.44, 61.38);
