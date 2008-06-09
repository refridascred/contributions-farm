-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (state, label, token, owner) VALUES ('latest', 'blue', 'cached', 'strict');
INSERT INTO stats_logs (state, label, token, owner) VALUES ('blue', 'stable', 'strict', 'primary');
INSERT INTO stats_logs (state, label, token, owner) VALUES ('strict', 'primary', 'stable', 'fallback');
