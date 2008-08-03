-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (ratio, score, active, owner) VALUES (53.0, 90.29, 55, 'standard');
INSERT INTO stats_logs (ratio, score, active, owner) VALUES (56.26, 30.16, 53, 'staging');
INSERT INTO stats_logs (ratio, score, active, owner) VALUES (75.83, 5.99, 91, 'standard');
