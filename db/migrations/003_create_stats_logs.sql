-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (count, token, state) VALUES (76, 'staging', 'standard');
INSERT INTO stats_logs (count, token, state) VALUES (44, 'open', 'latest');
INSERT INTO stats_logs (count, token, state) VALUES (69, 'standard', 'edge');
