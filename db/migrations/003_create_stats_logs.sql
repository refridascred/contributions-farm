-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (label, owner, weight, state) VALUES ('cached', 'fallback', 49.67, 'cached');
INSERT INTO stats_logs (label, owner, weight, state) VALUES ('standard', 'staging', 3.47, 'eu-west');
