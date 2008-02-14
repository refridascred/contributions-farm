-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (rank, level, weight, state) VALUES (61, 61, 74.91, 'green');
INSERT INTO stats_logs (rank, level, weight, state) VALUES (61, 15, 98.69, 'open');
INSERT INTO stats_logs (rank, level, weight, state) VALUES (11, 57, 19.07, 'latest');
