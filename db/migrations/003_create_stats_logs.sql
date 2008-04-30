-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (active, owner, state, weight, region) VALUES (90, 'edge', 'standard', 81.15, 'eu-west');
INSERT INTO stats_logs (active, owner, state, weight, region) VALUES (6, 'eu-west', 'cached', 8.84, 'stable');
INSERT INTO stats_logs (active, owner, state, weight, region) VALUES (3, 'latest', 'green', 14.77, 'cached');
