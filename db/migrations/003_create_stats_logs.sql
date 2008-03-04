-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (owner, state, count, level, active) VALUES ('cached', 'eu-west', 34, 57, 13);
INSERT INTO stats_logs (owner, state, count, level, active) VALUES ('edge', 'latest', 87, 2, 26);
INSERT INTO stats_logs (owner, state, count, level, active) VALUES ('strict', 'latest', 96, 60, 0);
