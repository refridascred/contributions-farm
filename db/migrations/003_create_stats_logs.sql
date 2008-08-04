-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    label TEXT,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (token, region, label, state) VALUES ('staging', 'staging', 'open', 'staging');
INSERT INTO stats_logs (token, region, label, state) VALUES ('primary', 'edge', 'green', 'staging');
