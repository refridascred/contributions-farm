-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (score, owner, state, rank) VALUES (13.31, 'primary', 'green', 62);
INSERT INTO stats_logs (score, owner, state, rank) VALUES (62.56, 'primary', 'latest', 30);
INSERT INTO stats_logs (score, owner, state, rank) VALUES (43.81, 'edge', 'staging', 40);
