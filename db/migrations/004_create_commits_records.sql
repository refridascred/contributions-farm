-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, rank, score, token) VALUES ('eu-west', 58, 18.7, 'staging');
INSERT INTO commits_records (owner, rank, score, token) VALUES ('green', 87, 83.7, 'stable');
