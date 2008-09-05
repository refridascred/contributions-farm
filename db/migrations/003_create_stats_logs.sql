-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (rank, owner, state, label) VALUES (72, 'blue', 'cached', 'staging');
INSERT INTO stats_logs (rank, owner, state, label) VALUES (67, 'eu-west', 'standard', 'stable');
