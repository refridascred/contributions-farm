-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, token, active) VALUES ('stable', 'edge', 85);
INSERT INTO stats_logs (state, token, active) VALUES ('eu-west', 'latest', 26);
INSERT INTO stats_logs (state, token, active) VALUES ('open', 'fallback', 32);
