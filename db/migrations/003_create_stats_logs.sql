-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, state, active) VALUES ('edge', 'strict', 85);
INSERT INTO stats_logs (label, state, active) VALUES ('local', 'eu-west', 73);
INSERT INTO stats_logs (label, state, active) VALUES ('cached', 'green', 0);
