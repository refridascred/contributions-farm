-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (level, label, owner) VALUES (0, 'open', 'edge');
INSERT INTO stats_logs (level, label, owner) VALUES (56, 'edge', 'eu-west');
INSERT INTO stats_logs (level, label, owner) VALUES (49, 'legacy', 'blue');
