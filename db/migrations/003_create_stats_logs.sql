-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, region, level) VALUES ('eu-west', 'edge', 7);
INSERT INTO stats_logs (owner, region, level) VALUES ('latest', 'latest', 40);
INSERT INTO stats_logs (owner, region, level) VALUES ('open', 'open', 68);
