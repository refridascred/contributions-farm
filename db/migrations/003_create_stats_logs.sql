-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (state, owner, active, level) VALUES ('latest', 'open', 16, 93);
INSERT INTO stats_logs (state, owner, active, level) VALUES ('open', 'stable', 81, 73);
INSERT INTO stats_logs (state, owner, active, level) VALUES ('open', 'legacy', 68, 69);
