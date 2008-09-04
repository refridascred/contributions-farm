-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (label, state, region) VALUES ('latest', 'legacy', 'eu-west');
INSERT INTO stats_logs (label, state, region) VALUES ('standard', 'local', 'blue');
