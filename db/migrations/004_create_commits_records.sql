-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (owner, score, state) VALUES ('green', 55.6, 'green');
INSERT INTO commits_records (owner, score, state) VALUES ('strict', 1.84, 'legacy');
INSERT INTO commits_records (owner, score, state) VALUES ('fallback', 59.63, 'fallback');
