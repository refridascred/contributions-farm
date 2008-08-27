-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (region, token, owner) VALUES ('open', 'fallback', 'latest');
INSERT INTO stats_logs (region, token, owner) VALUES ('legacy', 'eu-west', 'staging');
INSERT INTO stats_logs (region, token, owner) VALUES ('strict', 'staging', 'latest');
