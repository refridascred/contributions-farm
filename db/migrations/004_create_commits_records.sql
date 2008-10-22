-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (state, rank, active, count, token) VALUES ('fallback', 28, 81, 27, 'blue');
INSERT INTO commits_records (state, rank, active, count, token) VALUES ('stable', 93, 61, 49, 'strict');
INSERT INTO commits_records (state, rank, active, count, token) VALUES ('eu-west', 43, 90, 55, 'primary');
