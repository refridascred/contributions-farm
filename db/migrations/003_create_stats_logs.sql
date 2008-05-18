-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (label, owner, level, active, state) VALUES ('edge', 'standard', 30, 85, 'eu-west');
INSERT INTO stats_logs (label, owner, level, active, state) VALUES ('green', 'cached', 39, 29, 'eu-west');
INSERT INTO stats_logs (label, owner, level, active, state) VALUES ('blue', 'primary', 50, 3, 'eu-west');
