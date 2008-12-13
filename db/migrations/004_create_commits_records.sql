-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (owner, score, state, rank, count) VALUES ('standard', 20.45, 'latest', 51, 77);
INSERT INTO commits_records (owner, score, state, rank, count) VALUES ('fallback', 57.06, 'standard', 71, 10);
INSERT INTO commits_records (owner, score, state, rank, count) VALUES ('strict', 12.21, 'standard', 9, 32);
