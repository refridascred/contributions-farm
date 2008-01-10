-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, weight, score, state) VALUES ('eu-west', 87.95, 2.36, 'edge');
INSERT INTO stats_logs (label, weight, score, state) VALUES ('strict', 43.11, 28.25, 'eu-west');
INSERT INTO stats_logs (label, weight, score, state) VALUES ('cached', 14.22, 4.16, 'blue');
