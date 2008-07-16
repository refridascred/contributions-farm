-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, region, state) VALUES ('local', 'open', 'primary');
INSERT INTO stats_logs (label, region, state) VALUES ('eu-west', 'staging', 'primary');
INSERT INTO stats_logs (label, region, state) VALUES ('staging', 'fallback', 'strict');
