-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, score, owner, label) VALUES ('cached', 39.33, 'blue', 'cached');
INSERT INTO stats_logs (state, score, owner, label) VALUES ('stable', 33.88, 'open', 'edge');
INSERT INTO stats_logs (state, score, owner, label) VALUES ('blue', 48.48, 'cached', 'green');
