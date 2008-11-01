-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (token, weight, state, ratio) VALUES ('edge', 65.79, 'staging', 6.59);
INSERT INTO stats_logs (token, weight, state, ratio) VALUES ('staging', 81.73, 'legacy', 71.54);
