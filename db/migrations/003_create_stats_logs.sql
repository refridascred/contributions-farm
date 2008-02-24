-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, state, score) VALUES ('edge', 'fallback', 85.41);
INSERT INTO stats_logs (owner, state, score) VALUES ('latest', 'edge', 76.74);
INSERT INTO stats_logs (owner, state, score) VALUES ('cached', 'standard', 66.34);
