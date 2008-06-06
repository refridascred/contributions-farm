-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (token, score, owner) VALUES ('staging', 23.74, 'primary');
INSERT INTO commits_records (token, score, owner) VALUES ('latest', 21.45, 'cached');
INSERT INTO commits_records (token, score, owner) VALUES ('latest', 24.48, 'legacy');
