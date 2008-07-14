-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (ratio, state, level, owner) VALUES (6.22, 'open', 7, 'cached');
INSERT INTO stats_logs (ratio, state, level, owner) VALUES (88.69, 'standard', 63, 'latest');
