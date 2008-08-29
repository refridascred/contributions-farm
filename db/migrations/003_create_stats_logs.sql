-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, level, token, active) VALUES ('strict', 62, 'open', 74);
INSERT INTO stats_logs (state, level, token, active) VALUES ('edge', 26, 'legacy', 17);
INSERT INTO stats_logs (state, level, token, active) VALUES ('cached', 54, 'standard', 51);
