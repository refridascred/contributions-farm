-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, owner) VALUES (83.01, 'green');
INSERT INTO stats_logs (score, owner) VALUES (35.48, 'strict');
INSERT INTO stats_logs (score, owner) VALUES (18.34, 'open');
