-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (weight, score, count, ratio, state) VALUES (69.03, 39.84, 93, 39.92, 'eu-west');
INSERT INTO stats_logs (weight, score, count, ratio, state) VALUES (4.15, 31.32, 57, 60.53, 'strict');
