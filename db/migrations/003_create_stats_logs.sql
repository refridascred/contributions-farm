-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (count, rank, label, owner, token) VALUES (40, 95, 'eu-west', 'local', 'strict');
INSERT INTO stats_logs (count, rank, label, owner, token) VALUES (0, 77, 'latest', 'edge', 'primary');
INSERT INTO stats_logs (count, rank, label, owner, token) VALUES (51, 89, 'standard', 'latest', 'fallback');
