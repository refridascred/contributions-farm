-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, ratio, state, count, region) VALUES ('edge', 7.11, 'stable', 46, 'edge');
INSERT INTO commits_records (token, ratio, state, count, region) VALUES ('blue', 42.55, 'cached', 46, 'green');
INSERT INTO commits_records (token, ratio, state, count, region) VALUES ('primary', 35.17, 'local', 55, 'stable');
