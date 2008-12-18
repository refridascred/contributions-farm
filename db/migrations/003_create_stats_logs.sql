-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, rank, weight, score, active) VALUES ('cached', 98, 85.4, 68.99, 3);
INSERT INTO stats_logs (state, rank, weight, score, active) VALUES ('stable', 77, 95.36, 4.32, 51);
INSERT INTO stats_logs (state, rank, weight, score, active) VALUES ('green', 1, 80.01, 28.47, 5);
