-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (label, count, state, owner) VALUES ('strict', 26, 'edge', 'fallback');
INSERT INTO stats_logs (label, count, state, owner) VALUES ('legacy', 2, 'eu-west', 'cached');
INSERT INTO stats_logs (label, count, state, owner) VALUES ('standard', 58, 'strict', 'legacy');
