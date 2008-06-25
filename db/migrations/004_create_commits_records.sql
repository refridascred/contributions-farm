-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (region, state, weight, count, owner) VALUES ('latest', 'edge', 92.49, 4, 'edge');
INSERT INTO commits_records (region, state, weight, count, owner) VALUES ('staging', 'strict', 54.75, 42, 'open');
INSERT INTO commits_records (region, state, weight, count, owner) VALUES ('legacy', 'legacy', 3.31, 54, 'cached');
