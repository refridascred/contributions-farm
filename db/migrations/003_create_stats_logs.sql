-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, state, weight) VALUES (39.71, 'local', 50.55);
INSERT INTO stats_logs (score, state, weight) VALUES (4.48, 'blue', 53.63);
INSERT INTO stats_logs (score, state, weight) VALUES (20.71, 'primary', 1.5);
