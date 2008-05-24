-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (active, token, weight, owner) VALUES (13, 'green', 42.03, 'fallback');
INSERT INTO stats_logs (active, token, weight, owner) VALUES (78, 'blue', 65.46, 'edge');
INSERT INTO stats_logs (active, token, weight, owner) VALUES (1, 'legacy', 28.1, 'edge');
