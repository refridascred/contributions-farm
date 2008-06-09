-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (active, score, state, owner) VALUES (7, 64.88, 'green', 'eu-west');
INSERT INTO stats_logs (active, score, state, owner) VALUES (19, 7.45, 'stable', 'blue');
INSERT INTO stats_logs (active, score, state, owner) VALUES (40, 58.06, 'staging', 'primary');
