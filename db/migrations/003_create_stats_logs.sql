-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    region TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (state, owner, region, ratio, count) VALUES ('latest', 'cached', 'green', 40.21, 24);
INSERT INTO stats_logs (state, owner, region, ratio, count) VALUES ('local', 'green', 'green', 62.24, 71);
INSERT INTO stats_logs (state, owner, region, ratio, count) VALUES ('eu-west', 'edge', 'open', 10.68, 19);
