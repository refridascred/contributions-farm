-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (active, region, label, rank) VALUES (83, 'blue', 'edge', 71);
INSERT INTO stats_logs (active, region, label, rank) VALUES (56, 'standard', 'edge', 69);
INSERT INTO stats_logs (active, region, label, rank) VALUES (12, 'local', 'eu-west', 26);
