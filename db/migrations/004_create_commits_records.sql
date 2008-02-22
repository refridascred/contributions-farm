-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, rank, count, region) VALUES ('open', 71, 36, 'edge');
INSERT INTO commits_records (token, rank, count, region) VALUES ('standard', 41, 81, 'fallback');
INSERT INTO commits_records (token, rank, count, region) VALUES ('blue', 47, 11, 'open');
