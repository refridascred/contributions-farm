-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (region, level, label, state, owner) VALUES ('standard', 39, 'open', 'green', 'local');
INSERT INTO stats_logs (region, level, label, state, owner) VALUES ('strict', 9, 'primary', 'fallback', 'primary');
