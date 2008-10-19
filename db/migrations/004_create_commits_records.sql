-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, score, rank, count, region) VALUES ('green', 21.28, 73, 84, 'legacy');
INSERT INTO commits_records (state, score, rank, count, region) VALUES ('green', 21.48, 82, 36, 'cached');
INSERT INTO commits_records (state, score, rank, count, region) VALUES ('staging', 29.8, 46, 17, 'open');
