-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (label, state, region, count) VALUES ('eu-west', 'latest', 'staging', 44);
INSERT INTO stats_logs (label, state, region, count) VALUES ('local', 'fallback', 'primary', 40);
INSERT INTO stats_logs (label, state, region, count) VALUES ('eu-west', 'primary', 'edge', 62);
