-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, state, label, count, ratio) VALUES ('staging', 'eu-west', 'legacy', 60, 91.49);
INSERT INTO stats_logs (owner, state, label, count, ratio) VALUES ('open', 'eu-west', 'stable', 6, 79.38);
INSERT INTO stats_logs (owner, state, label, count, ratio) VALUES ('staging', 'staging', 'latest', 11, 66.28);
