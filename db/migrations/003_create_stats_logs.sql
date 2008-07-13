-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, token, label, score) VALUES ('blue', 'legacy', 'eu-west', 63.74);
INSERT INTO stats_logs (state, token, label, score) VALUES ('local', 'edge', 'local', 22.46);
