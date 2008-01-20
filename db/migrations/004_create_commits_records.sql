-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, rank, score, state, token) VALUES (63, 15, 61.0, 'latest', 'blue');
INSERT INTO commits_records (count, rank, score, state, token) VALUES (89, 17, 96.3, 'stable', 'staging');
INSERT INTO commits_records (count, rank, score, state, token) VALUES (24, 44, 1.16, 'cached', 'green');
