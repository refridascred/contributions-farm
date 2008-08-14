-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, rank, state, token) VALUES (68.59, 7, 'legacy', 'cached');
INSERT INTO stats_logs (weight, rank, state, token) VALUES (10.92, 54, 'edge', 'green');
