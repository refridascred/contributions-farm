-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    created_at TIMESTAMP,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (owner, weight, ratio, score) VALUES ('staging', 64.55, 36.25, 83.88);
INSERT INTO stats_logs (owner, weight, ratio, score) VALUES ('cached', 0.18, 70.64, 94.9);
