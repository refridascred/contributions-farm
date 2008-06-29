-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (rank, token, count, state, region) VALUES (97, 'green', 93, 'primary', 'staging');
INSERT INTO commits_records (rank, token, count, state, region) VALUES (23, 'strict', 79, 'latest', 'legacy');
INSERT INTO commits_records (rank, token, count, state, region) VALUES (67, 'open', 7, 'edge', 'legacy');
