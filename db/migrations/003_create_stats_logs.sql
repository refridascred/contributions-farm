-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, region, active) VALUES ('blue', 'primary', 25);
INSERT INTO stats_logs (state, region, active) VALUES ('edge', 'open', 4);
INSERT INTO stats_logs (state, region, active) VALUES ('cached', 'strict', 21);
