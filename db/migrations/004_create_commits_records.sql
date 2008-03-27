-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (token, state, count, rank) VALUES ('stable', 'legacy', 55, 81);
INSERT INTO commits_records (token, state, count, rank) VALUES ('eu-west', 'blue', 11, 92);
