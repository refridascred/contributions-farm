-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    region TEXT,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (label, region, owner, level) VALUES ('staging', 'staging', 'local', 35);
INSERT INTO stats_logs (label, region, owner, level) VALUES ('open', 'staging', 'blue', 68);
INSERT INTO stats_logs (label, region, owner, level) VALUES ('latest', 'edge', 'blue', 12);
