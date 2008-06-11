-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (owner, label, state, count) VALUES ('standard', 'strict', 'legacy', 95);
INSERT INTO stats_logs (owner, label, state, count) VALUES ('fallback', 'cached', 'green', 18);
