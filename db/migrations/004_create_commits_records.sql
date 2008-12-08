-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (active, count, state) VALUES (22, 66, 'standard');
INSERT INTO commits_records (active, count, state) VALUES (49, 58, 'fallback');
INSERT INTO commits_records (active, count, state) VALUES (67, 8, 'strict');
