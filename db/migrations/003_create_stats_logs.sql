-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (owner, weight, token) VALUES ('staging', 25.58, 'strict');
INSERT INTO stats_logs (owner, weight, token) VALUES ('stable', 73.18, 'edge');
INSERT INTO stats_logs (owner, weight, token) VALUES ('staging', 45.71, 'legacy');
