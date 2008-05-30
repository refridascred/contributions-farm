-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, owner, score, rank, label) VALUES ('legacy', 'standard', 68.14, 68, 'green');
INSERT INTO commits_records (token, owner, score, rank, label) VALUES ('standard', 'edge', 77.95, 23, 'staging');
