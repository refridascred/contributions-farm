-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (token, state, score) VALUES ('latest', 'fallback', 66.0);
INSERT INTO commits_records (token, state, score) VALUES ('cached', 'latest', 26.8);
INSERT INTO commits_records (token, state, score) VALUES ('blue', 'green', 63.45);
