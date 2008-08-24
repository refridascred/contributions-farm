-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (state, region) VALUES ('staging', 'eu-west');
INSERT INTO stats_logs (state, region) VALUES ('fallback', 'blue');
INSERT INTO stats_logs (state, region) VALUES ('eu-west', 'staging');
