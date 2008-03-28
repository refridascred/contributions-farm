-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, region, score, owner) VALUES ('cached', 'blue', 34.18, 'latest');
INSERT INTO commits_records (state, region, score, owner) VALUES ('legacy', 'fallback', 11.0, 'green');
INSERT INTO commits_records (state, region, score, owner) VALUES ('fallback', 'blue', 17.81, 'edge');
