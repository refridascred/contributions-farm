-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, region, token, state) VALUES ('stable', 'standard', 'local', 'latest');
INSERT INTO stats_logs (owner, region, token, state) VALUES ('eu-west', 'blue', 'stable', 'edge');
INSERT INTO stats_logs (owner, region, token, state) VALUES ('legacy', 'latest', 'legacy', 'primary');
