-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, score, state, count) VALUES ('blue', 96.06, 'standard', 70);
INSERT INTO commits_records (region, score, state, count) VALUES ('eu-west', 70.03, 'edge', 16);
INSERT INTO commits_records (region, score, state, count) VALUES ('open', 16.25, 'edge', 94);
