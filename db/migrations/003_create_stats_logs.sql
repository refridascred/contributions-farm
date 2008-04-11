-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (state, label, region, active) VALUES ('cached', 'cached', 'cached', 90);
INSERT INTO stats_logs (state, label, region, active) VALUES ('fallback', 'staging', 'eu-west', 12);
