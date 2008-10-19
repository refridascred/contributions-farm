-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, ratio, rank, token) VALUES ('eu-west', 13.3, 64, 'fallback');
INSERT INTO commits_records (owner, ratio, rank, token) VALUES ('eu-west', 32.67, 59, 'latest');
