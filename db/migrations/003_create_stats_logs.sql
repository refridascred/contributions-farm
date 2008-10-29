-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (region, token, state, label) VALUES ('strict', 'eu-west', 'legacy', 'primary');
INSERT INTO stats_logs (region, token, state, label) VALUES ('latest', 'green', 'edge', 'open');
INSERT INTO stats_logs (region, token, state, label) VALUES ('staging', 'green', 'strict', 'open');
