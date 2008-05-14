-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, state, score) VALUES (81.84, 'strict', 8.71);
INSERT INTO commits_records (ratio, state, score) VALUES (74.89, 'legacy', 48.17);
INSERT INTO commits_records (ratio, state, score) VALUES (31.99, 'staging', 5.51);
