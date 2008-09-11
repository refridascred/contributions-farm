-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (state, count, score) VALUES ('strict', 10, 41.98);
INSERT INTO commits_records (state, count, score) VALUES ('legacy', 8, 31.31);
INSERT INTO commits_records (state, count, score) VALUES ('edge', 50, 37.26);
