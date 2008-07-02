-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, rank, token, state, level) VALUES (97, 46, 'fallback', 'cached', 5);
INSERT INTO commits_records (count, rank, token, state, level) VALUES (7, 64, 'strict', 'blue', 59);
