-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, label, rank, owner) VALUES ('stable', 'cached', 19, 'standard');
INSERT INTO commits_records (token, label, rank, owner) VALUES ('latest', 'standard', 13, 'cached');
INSERT INTO commits_records (token, label, rank, owner) VALUES ('standard', 'legacy', 62, 'latest');
