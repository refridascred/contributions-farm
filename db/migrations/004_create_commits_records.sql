-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (count, state, token, ratio, rank) VALUES (13, 'edge', 'open', 3.2, 27);
