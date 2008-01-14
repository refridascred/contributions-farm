-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (owner, token, level, active, label) VALUES ('fallback', 'edge', 43, 2, 'legacy');
INSERT INTO stats_logs (owner, token, level, active, label) VALUES ('open', 'edge', 46, 86, 'primary');
