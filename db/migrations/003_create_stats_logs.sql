-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (state, token, level, label) VALUES ('legacy', 'primary', 71, 'primary');
INSERT INTO stats_logs (state, token, level, label) VALUES ('strict', 'staging', 94, 'staging');
