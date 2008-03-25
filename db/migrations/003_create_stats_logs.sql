-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (state, label, active, level) VALUES ('fallback', 'strict', 57, 13);
INSERT INTO stats_logs (state, label, active, level) VALUES ('edge', 'strict', 75, 37);
INSERT INTO stats_logs (state, label, active, level) VALUES ('edge', 'eu-west', 20, 81);
