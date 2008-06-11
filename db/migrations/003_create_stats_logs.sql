-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (label, state, owner, rank) VALUES ('open', 'edge', 'open', 14);
INSERT INTO stats_logs (label, state, owner, rank) VALUES ('cached', 'local', 'staging', 54);
