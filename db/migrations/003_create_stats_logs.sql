-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (owner, label) VALUES ('standard', 'green');
INSERT INTO stats_logs (owner, label) VALUES ('strict', 'edge');
INSERT INTO stats_logs (owner, label) VALUES ('cached', 'fallback');
