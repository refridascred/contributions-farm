-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (owner, state, token, score, label) VALUES ('local', 'blue', 'standard', 18.86, 'legacy');
INSERT INTO stats_logs (owner, state, token, score, label) VALUES ('open', 'legacy', 'staging', 14.39, 'fallback');
