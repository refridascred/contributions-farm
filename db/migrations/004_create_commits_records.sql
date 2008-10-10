-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, count, owner, region, ratio) VALUES ('edge', 95, 'open', 'cached', 64.24);
INSERT INTO commits_records (state, count, owner, region, ratio) VALUES ('fallback', 2, 'edge', 'strict', 82.71);
