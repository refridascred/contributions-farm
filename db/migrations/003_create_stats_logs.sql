-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (weight, rank, state, count) VALUES (5.35, 28, 'blue', 76);
INSERT INTO stats_logs (weight, rank, state, count) VALUES (91.17, 47, 'edge', 92);
INSERT INTO stats_logs (weight, rank, state, count) VALUES (51.99, 50, 'strict', 75);
