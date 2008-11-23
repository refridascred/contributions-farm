-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (owner, level, count, state, weight) VALUES ('local', 27, 96, 'cached', 7.56);
INSERT INTO stats_logs (owner, level, count, state, weight) VALUES ('local', 75, 98, 'edge', 92.84);
