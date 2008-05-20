-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (label, state, weight) VALUES ('fallback', 'fallback', 19.28);
INSERT INTO stats_logs (label, state, weight) VALUES ('standard', 'stable', 32.93);
INSERT INTO stats_logs (label, state, weight) VALUES ('standard', 'latest', 39.22);
