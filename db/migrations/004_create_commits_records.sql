-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (count, rank, score, state) VALUES (99, 93, 95.84, 'open');
INSERT INTO commits_records (count, rank, score, state) VALUES (88, 32, 62.4, 'cached');
