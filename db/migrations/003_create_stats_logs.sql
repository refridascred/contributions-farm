-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (label, state, level) VALUES ('local', 'open', 20);
INSERT INTO stats_logs (label, state, level) VALUES ('standard', 'green', 10);
INSERT INTO stats_logs (label, state, level) VALUES ('green', 'primary', 93);
