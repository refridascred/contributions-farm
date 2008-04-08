-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, score, rank, level) VALUES ('standard', 37.0, 67, 46);
INSERT INTO commits_records (owner, score, rank, level) VALUES ('fallback', 34.33, 69, 5);
