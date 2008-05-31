-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, label, active, ratio) VALUES ('fallback', 'eu-west', 17, 20.67);
INSERT INTO stats_logs (state, label, active, ratio) VALUES ('standard', 'cached', 49, 83.05);
INSERT INTO stats_logs (state, label, active, ratio) VALUES ('strict', 'standard', 98, 48.4);
