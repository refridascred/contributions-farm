-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (token, rank, count, region) VALUES ('latest', 95, 92, 'cached');
INSERT INTO commits_records (token, rank, count, region) VALUES ('staging', 35, 47, 'local');
INSERT INTO commits_records (token, rank, count, region) VALUES ('open', 0, 94, 'local');
