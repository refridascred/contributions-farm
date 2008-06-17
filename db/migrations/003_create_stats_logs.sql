-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (owner, count, state) VALUES ('strict', 61, 'primary');
INSERT INTO stats_logs (owner, count, state) VALUES ('local', 27, 'eu-west');
INSERT INTO stats_logs (owner, count, state) VALUES ('staging', 31, 'green');
