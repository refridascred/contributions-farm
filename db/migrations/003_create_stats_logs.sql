-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (rank, ratio, weight, state, score) VALUES (31, 92.27, 72.89, 'blue', 36.14);
INSERT INTO stats_logs (rank, ratio, weight, state, score) VALUES (29, 74.89, 72.19, 'strict', 10.41);
