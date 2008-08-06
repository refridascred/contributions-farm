-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (count, state, label, ratio) VALUES (56, 'staging', 'cached', 14.4);
INSERT INTO stats_logs (count, state, label, ratio) VALUES (48, 'fallback', 'fallback', 92.92);
