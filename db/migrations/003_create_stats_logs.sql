-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (token, owner, score, state) VALUES ('strict', 'primary', 53.02, 'local');
INSERT INTO stats_logs (token, owner, score, state) VALUES ('local', 'strict', 83.26, 'eu-west');
