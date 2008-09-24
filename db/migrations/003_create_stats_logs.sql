-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (active, state, token, rank, weight) VALUES (84, 'standard', 'standard', 29, 35.68);
INSERT INTO stats_logs (active, state, token, rank, weight) VALUES (36, 'staging', 'eu-west', 21, 53.03);
