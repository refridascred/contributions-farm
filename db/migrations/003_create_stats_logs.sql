-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, level, region) VALUES ('open', 8, 'standard');
INSERT INTO stats_logs (owner, level, region) VALUES ('staging', 74, 'local');
INSERT INTO stats_logs (owner, level, region) VALUES ('open', 92, 'blue');
