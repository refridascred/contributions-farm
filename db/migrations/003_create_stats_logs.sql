-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (ratio, owner, state, weight, token) VALUES (77.31, 'latest', 'eu-west', 7.74, 'strict');
INSERT INTO stats_logs (ratio, owner, state, weight, token) VALUES (9.25, 'strict', 'blue', 98.99, 'edge');
