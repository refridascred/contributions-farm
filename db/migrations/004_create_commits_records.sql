-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (token, count, state, region) VALUES ('eu-west', 66, 'legacy', 'legacy');
INSERT INTO commits_records (token, count, state, region) VALUES ('strict', 84, 'strict', 'local');
INSERT INTO commits_records (token, count, state, region) VALUES ('standard', 58, 'cached', 'primary');
