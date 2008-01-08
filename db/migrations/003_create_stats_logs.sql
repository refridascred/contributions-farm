-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (level, state, label) VALUES (87, 'eu-west', 'open');
INSERT INTO stats_logs (level, state, label) VALUES (56, 'latest', 'strict');
INSERT INTO stats_logs (level, state, label) VALUES (98, 'standard', 'primary');
