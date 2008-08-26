-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (weight, score, state, level) VALUES (29.97, 57.2, 'stable', 97);
INSERT INTO stats_logs (weight, score, state, level) VALUES (17.37, 61.23, 'stable', 78);
INSERT INTO stats_logs (weight, score, state, level) VALUES (51.81, 97.36, 'eu-west', 24);
