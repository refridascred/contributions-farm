-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, weight, owner) VALUES (63.99, 86.93, 'legacy');
INSERT INTO stats_logs (score, weight, owner) VALUES (52.53, 0.59, 'standard');
INSERT INTO stats_logs (score, weight, owner) VALUES (92.19, 18.68, 'standard');
