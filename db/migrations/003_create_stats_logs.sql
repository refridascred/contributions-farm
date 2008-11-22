-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (owner, label, rank, active, state) VALUES ('strict', 'stable', 46, 56, 'strict');
