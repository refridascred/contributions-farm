-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (token, active, state, rank, label) VALUES ('staging', 24, 'standard', 62, 'eu-west');
INSERT INTO stats_logs (token, active, state, rank, label) VALUES ('local', 61, 'latest', 28, 'eu-west');
