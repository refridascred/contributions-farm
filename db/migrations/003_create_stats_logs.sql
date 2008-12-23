-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (label, token, state, rank) VALUES ('latest', 'legacy', 'eu-west', 2);
INSERT INTO stats_logs (label, token, state, rank) VALUES ('local', 'strict', 'primary', 44);
INSERT INTO stats_logs (label, token, state, rank) VALUES ('staging', 'stable', 'staging', 63);
