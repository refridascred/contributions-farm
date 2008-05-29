-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, state, level) VALUES (55, 'eu-west', 46);
INSERT INTO stats_logs (active, state, level) VALUES (17, 'local', 66);
INSERT INTO stats_logs (active, state, level) VALUES (47, 'latest', 73);
