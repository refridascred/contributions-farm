-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (count, owner, state, rank, region) VALUES (30, 'primary', 'open', 34, 'blue');
INSERT INTO stats_logs (count, owner, state, rank, region) VALUES (39, 'cached', 'cached', 7, 'open');
INSERT INTO stats_logs (count, owner, state, rank, region) VALUES (53, 'eu-west', 'staging', 17, 'legacy');
