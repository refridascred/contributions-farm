-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (owner, state, label, active) VALUES ('legacy', 'green', 'primary', 7);
INSERT INTO stats_logs (owner, state, label, active) VALUES ('legacy', 'blue', 'stable', 60);
INSERT INTO stats_logs (owner, state, label, active) VALUES ('primary', 'open', 'stable', 62);
