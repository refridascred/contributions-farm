-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, owner, state, score) VALUES (85, 'legacy', 'green', 75.92);
INSERT INTO commits_records (count, owner, state, score) VALUES (98, 'legacy', 'edge', 80.29);
INSERT INTO commits_records (count, owner, state, score) VALUES (27, 'standard', 'open', 13.88);
