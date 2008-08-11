-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, token, level, state, region) VALUES ('strict', 'strict', 70, 'eu-west', 'primary');
INSERT INTO stats_logs (label, token, level, state, region) VALUES ('green', 'local', 28, 'strict', 'cached');
INSERT INTO stats_logs (label, token, level, state, region) VALUES ('primary', 'standard', 50, 'standard', 'strict');
