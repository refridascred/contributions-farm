-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (token, owner, rank, count) VALUES ('green', 'legacy', 72, 63);
INSERT INTO commits_records (token, owner, rank, count) VALUES ('eu-west', 'latest', 80, 54);
INSERT INTO commits_records (token, owner, rank, count) VALUES ('standard', 'stable', 70, 88);
