-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, score, state, active) VALUES (9.58, 46.42, 'eu-west', 37);
INSERT INTO stats_logs (weight, score, state, active) VALUES (49.15, 23.87, 'cached', 28);
INSERT INTO stats_logs (weight, score, state, active) VALUES (33.43, 54.46, 'legacy', 77);
