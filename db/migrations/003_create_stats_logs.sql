-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, active, rank, token) VALUES ('strict', 71, 7, 'standard');
INSERT INTO stats_logs (state, active, rank, token) VALUES ('green', 8, 79, 'legacy');
INSERT INTO stats_logs (state, active, rank, token) VALUES ('stable', 13, 96, 'eu-west');
