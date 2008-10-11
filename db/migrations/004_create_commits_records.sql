-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, region, rank, score, owner) VALUES ('legacy', 'open', 71, 98.85, 'local');
INSERT INTO commits_records (token, region, rank, score, owner) VALUES ('eu-west', 'staging', 30, 64.4, 'open');
INSERT INTO commits_records (token, region, rank, score, owner) VALUES ('legacy', 'cached', 80, 69.89, 'legacy');
