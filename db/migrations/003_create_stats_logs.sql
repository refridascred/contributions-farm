-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, label, state, ratio) VALUES ('fallback', 'staging', 'cached', 84.96);
INSERT INTO stats_logs (token, label, state, ratio) VALUES ('staging', 'standard', 'fallback', 28.34);
INSERT INTO stats_logs (token, label, state, ratio) VALUES ('cached', 'edge', 'standard', 31.43);
