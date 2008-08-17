-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, weight, score, region) VALUES ('fallback', 68.43, 61.38, 'edge');
INSERT INTO commits_records (state, weight, score, region) VALUES ('open', 87.42, 42.25, 'edge');
