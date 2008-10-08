-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, active, state, weight) VALUES (66.2, 66, 'strict', 38.82);
INSERT INTO stats_logs (score, active, state, weight) VALUES (35.5, 20, 'standard', 84.91);
INSERT INTO stats_logs (score, active, state, weight) VALUES (45.44, 97, 'green', 4.63);
