-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (level, owner, label, state) VALUES (26, 'blue', 'fallback', 'latest');
INSERT INTO stats_logs (level, owner, label, state) VALUES (79, 'primary', 'legacy', 'edge');
INSERT INTO stats_logs (level, owner, label, state) VALUES (58, 'cached', 'strict', 'local');
