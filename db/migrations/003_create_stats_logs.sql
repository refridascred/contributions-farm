-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (state, rank, weight, token) VALUES ('local', 86, 31.12, 'green');
INSERT INTO stats_logs (state, rank, weight, token) VALUES ('edge', 63, 2.25, 'blue');
