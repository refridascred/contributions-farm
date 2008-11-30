-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (owner, level, state, ratio) VALUES ('green', 50, 'open', 72.41);
INSERT INTO stats_logs (owner, level, state, ratio) VALUES ('standard', 95, 'primary', 84.88);
INSERT INTO stats_logs (owner, level, state, ratio) VALUES ('edge', 75, 'cached', 15.59);
