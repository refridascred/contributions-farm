-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, token, label, region) VALUES ('edge', 'staging', 'legacy', 'fallback');
INSERT INTO stats_logs (owner, token, label, region) VALUES ('edge', 'strict', 'open', 'cached');
INSERT INTO stats_logs (owner, token, label, region) VALUES ('open', 'local', 'latest', 'open');
