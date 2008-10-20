-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, owner, count, token, region) VALUES ('strict', 'legacy', 48, 'green', 'standard');
INSERT INTO stats_logs (state, owner, count, token, region) VALUES ('legacy', 'stable', 0, 'stable', 'eu-west');
