-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (level, state, label) VALUES (12, 'local', 'latest');
INSERT INTO stats_logs (level, state, label) VALUES (36, 'primary', 'cached');
INSERT INTO stats_logs (level, state, label) VALUES (91, 'blue', 'standard');
