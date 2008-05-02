-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (token, label, count, rank, region) VALUES ('staging', 'edge', 53, 49, 'eu-west');
INSERT INTO stats_logs (token, label, count, rank, region) VALUES ('open', 'fallback', 78, 25, 'legacy');
INSERT INTO stats_logs (token, label, count, rank, region) VALUES ('primary', 'edge', 44, 41, 'strict');
