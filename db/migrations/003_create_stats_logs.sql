-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (token, state, weight) VALUES ('green', 'staging', 45.3);
INSERT INTO stats_logs (token, state, weight) VALUES ('legacy', 'stable', 77.64);
