-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (owner, score, state, rank) VALUES ('edge', 70.73, 'strict', 56);
INSERT INTO stats_logs (owner, score, state, rank) VALUES ('primary', 47.92, 'standard', 54);
INSERT INTO stats_logs (owner, score, state, rank) VALUES ('strict', 97.36, 'staging', 41);
