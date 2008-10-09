-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (owner, state, active, ratio, token) VALUES ('blue', 'green', 18, 42.61, 'primary');
INSERT INTO stats_logs (owner, state, active, ratio, token) VALUES ('eu-west', 'latest', 27, 92.91, 'edge');
INSERT INTO stats_logs (owner, state, active, ratio, token) VALUES ('blue', 'edge', 53, 18.35, 'eu-west');
