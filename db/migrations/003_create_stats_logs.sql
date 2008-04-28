-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, owner, active, label, weight) VALUES (1, 'latest', 81, 'edge', 72.26);
INSERT INTO stats_logs (count, owner, active, label, weight) VALUES (47, 'standard', 29, 'cached', 94.49);
