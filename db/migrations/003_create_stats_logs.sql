-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (token, level, state, label) VALUES ('legacy', 39, 'green', 'eu-west');
INSERT INTO stats_logs (token, level, state, label) VALUES ('green', 91, 'open', 'standard');
