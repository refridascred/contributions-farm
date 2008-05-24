-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (rank, region, count, label, token) VALUES (55, 'legacy', 15, 'fallback', 'legacy');
INSERT INTO commits_records (rank, region, count, label, token) VALUES (67, 'strict', 64, 'eu-west', 'stable');
