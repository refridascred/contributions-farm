-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (state, label, weight) VALUES ('stable', 'edge', 86.93);
INSERT INTO stats_logs (state, label, weight) VALUES ('fallback', 'eu-west', 65.7);
INSERT INTO stats_logs (state, label, weight) VALUES ('legacy', 'green', 9.69);
