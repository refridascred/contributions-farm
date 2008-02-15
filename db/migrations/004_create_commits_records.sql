-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (state, label, score, count, region) VALUES ('open', 'legacy', 24.14, 86, 'latest');
INSERT INTO commits_records (state, label, score, count, region) VALUES ('cached', 'cached', 16.03, 16, 'cached');
