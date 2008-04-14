-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (label, owner, rank, state) VALUES ('staging', 'cached', 18, 'strict');
INSERT INTO stats_logs (label, owner, rank, state) VALUES ('eu-west', 'stable', 35, 'fallback');
