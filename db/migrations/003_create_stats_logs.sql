-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, label, token, state) VALUES (38.51, 'local', 'primary', 'standard');
INSERT INTO stats_logs (ratio, label, token, state) VALUES (63.68, 'open', 'primary', 'local');
INSERT INTO stats_logs (ratio, label, token, state) VALUES (26.74, 'eu-west', 'edge', 'strict');
