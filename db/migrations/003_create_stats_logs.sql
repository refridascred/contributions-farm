-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (label, state, ratio, region) VALUES ('standard', 'open', 28.56, 'standard');
INSERT INTO stats_logs (label, state, ratio, region) VALUES ('open', 'green', 44.44, 'staging');
INSERT INTO stats_logs (label, state, ratio, region) VALUES ('local', 'strict', 92.2, 'local');
