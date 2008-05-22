-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    created_at TIMESTAMP,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, label, token, state) VALUES ('standard', 'standard', 'strict', 'blue');
INSERT INTO stats_logs (region, label, token, state) VALUES ('edge', 'eu-west', 'open', 'eu-west');
INSERT INTO stats_logs (region, label, token, state) VALUES ('staging', 'edge', 'strict', 'primary');
