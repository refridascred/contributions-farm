-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (label, count, token, rank) VALUES ('standard', 78, 'cached', 23);
INSERT INTO stats_logs (label, count, token, rank) VALUES ('green', 85, 'green', 18);
