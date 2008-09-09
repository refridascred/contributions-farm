-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (active, owner, label, rank) VALUES (34, 'blue', 'edge', 19);
INSERT INTO stats_logs (active, owner, label, rank) VALUES (65, 'eu-west', 'green', 17);
