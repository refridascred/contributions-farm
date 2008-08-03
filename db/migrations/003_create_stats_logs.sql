-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, weight, state, region) VALUES ('eu-west', 12.58, 'primary', 'stable');
INSERT INTO stats_logs (label, weight, state, region) VALUES ('local', 74.22, 'cached', 'primary');
INSERT INTO stats_logs (label, weight, state, region) VALUES ('open', 27.13, 'local', 'legacy');
