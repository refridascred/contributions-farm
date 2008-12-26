-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (owner, count, token, label, region) VALUES ('cached', 79, 'eu-west', 'local', 'open');
INSERT INTO stats_logs (owner, count, token, label, region) VALUES ('eu-west', 5, 'eu-west', 'open', 'eu-west');
INSERT INTO stats_logs (owner, count, token, label, region) VALUES ('eu-west', 66, 'cached', 'strict', 'latest');
