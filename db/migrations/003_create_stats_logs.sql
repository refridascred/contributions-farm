-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, token, owner, level, ratio) VALUES ('strict', 'standard', 'staging', 33, 39.61);
INSERT INTO stats_logs (state, token, owner, level, ratio) VALUES ('local', 'standard', 'blue', 54, 28.14);
