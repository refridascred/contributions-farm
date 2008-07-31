-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (label, owner, rank, token) VALUES ('standard', 'strict', 21, 'fallback');
INSERT INTO stats_logs (label, owner, rank, token) VALUES ('stable', 'fallback', 1, 'standard');
