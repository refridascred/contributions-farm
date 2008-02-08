-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (level, region, owner) VALUES (29, 'staging', 'edge');
INSERT INTO stats_logs (level, region, owner) VALUES (69, 'eu-west', 'staging');
