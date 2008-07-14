-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (label, state, count, owner) VALUES ('blue', 'primary', 49, 'standard');
INSERT INTO stats_logs (label, state, count, owner) VALUES ('eu-west', 'legacy', 84, 'latest');
INSERT INTO stats_logs (label, state, count, owner) VALUES ('cached', 'edge', 67, 'stable');
