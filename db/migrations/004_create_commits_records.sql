-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (state, count, level, score) VALUES ('legacy', 91, 47, 2.64);
