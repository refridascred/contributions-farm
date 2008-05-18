-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (weight, state, active) VALUES (33.14, 'eu-west', 10);
INSERT INTO stats_logs (weight, state, active) VALUES (57.4, 'strict', 20);
INSERT INTO stats_logs (weight, state, active) VALUES (79.37, 'staging', 97);
