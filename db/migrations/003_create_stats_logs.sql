-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    rank INTEGER,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (count, ratio, rank, token, label) VALUES (25, 22.08, 18, 'green', 'edge');
INSERT INTO stats_logs (count, ratio, rank, token, label) VALUES (83, 30.23, 68, 'cached', 'standard');
