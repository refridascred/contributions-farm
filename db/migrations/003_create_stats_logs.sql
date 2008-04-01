-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, weight, score) VALUES ('stable', 42.39, 5.21);
INSERT INTO stats_logs (state, weight, score) VALUES ('staging', 42.29, 32.79);
INSERT INTO stats_logs (state, weight, score) VALUES ('edge', 28.36, 48.84);
