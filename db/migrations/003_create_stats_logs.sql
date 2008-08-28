-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (level, label, state, region) VALUES (13, 'staging', 'open', 'strict');
INSERT INTO stats_logs (level, label, state, region) VALUES (42, 'blue', 'local', 'primary');
INSERT INTO stats_logs (level, label, state, region) VALUES (13, 'legacy', 'open', 'fallback');
