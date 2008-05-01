-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (region, weight, score, owner) VALUES ('staging', 76.71, 67.38, 'edge');
INSERT INTO stats_logs (region, weight, score, owner) VALUES ('strict', 45.89, 16.5, 'stable');
