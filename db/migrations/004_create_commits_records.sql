-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (state, weight, score, token) VALUES ('latest', 62.38, 64.83, 'eu-west');
INSERT INTO commits_records (state, weight, score, token) VALUES ('standard', 41.15, 4.2, 'cached');
INSERT INTO commits_records (state, weight, score, token) VALUES ('blue', 96.41, 39.33, 'latest');
