-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (label, state, token, level) VALUES ('strict', 'stable', 'primary', 75);
INSERT INTO stats_logs (label, state, token, level) VALUES ('edge', 'latest', 'staging', 93);
INSERT INTO stats_logs (label, state, token, level) VALUES ('staging', 'green', 'staging', 44);
