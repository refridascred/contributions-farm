-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (owner, state, level, score, count) VALUES ('edge', 'edge', 2, 29.81, 52);
INSERT INTO stats_logs (owner, state, level, score, count) VALUES ('primary', 'primary', 68, 82.46, 2);
INSERT INTO stats_logs (owner, state, level, score, count) VALUES ('blue', 'staging', 30, 29.66, 99);
