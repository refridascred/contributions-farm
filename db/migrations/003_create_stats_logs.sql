-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (count, label, token, state) VALUES (72, 'latest', 'eu-west', 'stable');
INSERT INTO stats_logs (count, label, token, state) VALUES (54, 'standard', 'open', 'green');
INSERT INTO stats_logs (count, label, token, state) VALUES (82, 'edge', 'strict', 'edge');
