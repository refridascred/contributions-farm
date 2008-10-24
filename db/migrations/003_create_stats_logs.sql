-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (count, token, state, label) VALUES (76, 'standard', 'legacy', 'stable');
INSERT INTO stats_logs (count, token, state, label) VALUES (91, 'eu-west', 'blue', 'fallback');
INSERT INTO stats_logs (count, token, state, label) VALUES (5, 'legacy', 'primary', 'legacy');
