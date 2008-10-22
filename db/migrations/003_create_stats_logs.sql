-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (label, state, token, rank) VALUES ('local', 'staging', 'green', 6);
INSERT INTO stats_logs (label, state, token, rank) VALUES ('cached', 'primary', 'staging', 87);
INSERT INTO stats_logs (label, state, token, rank) VALUES ('primary', 'legacy', 'latest', 33);
