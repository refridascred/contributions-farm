-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, level, state) VALUES ('fallback', 95, 'edge');
INSERT INTO stats_logs (label, level, state) VALUES ('eu-west', 66, 'eu-west');
INSERT INTO stats_logs (label, level, state) VALUES ('staging', 4, 'green');
