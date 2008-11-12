-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (region, count, owner) VALUES ('latest', 59, 'cached');
INSERT INTO stats_logs (region, count, owner) VALUES ('local', 11, 'stable');
INSERT INTO stats_logs (region, count, owner) VALUES ('blue', 1, 'eu-west');
