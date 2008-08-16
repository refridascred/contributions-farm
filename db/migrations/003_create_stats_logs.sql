-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, ratio, active) VALUES ('legacy', 62.75, 23);
INSERT INTO stats_logs (state, ratio, active) VALUES ('fallback', 5.34, 87);
