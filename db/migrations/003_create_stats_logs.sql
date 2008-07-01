-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (label, state) VALUES ('stable', 'fallback');
INSERT INTO stats_logs (label, state) VALUES ('open', 'latest');
INSERT INTO stats_logs (label, state) VALUES ('open', 'stable');
