-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (label, region, state) VALUES ('standard', 'standard', 'open');
INSERT INTO stats_logs (label, region, state) VALUES ('standard', 'strict', 'open');
INSERT INTO stats_logs (label, region, state) VALUES ('edge', 'stable', 'eu-west');
