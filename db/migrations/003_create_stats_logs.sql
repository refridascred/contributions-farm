-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (owner, state, score) VALUES ('stable', 'local', 90.52);
INSERT INTO stats_logs (owner, state, score) VALUES ('local', 'blue', 54.29);
INSERT INTO stats_logs (owner, state, score) VALUES ('local', 'legacy', 71.32);
