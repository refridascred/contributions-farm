-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    created_at TIMESTAMP,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (state, level, token, region) VALUES ('fallback', 96, 'legacy', 'legacy');
INSERT INTO commits_records (state, level, token, region) VALUES ('blue', 41, 'eu-west', 'strict');
INSERT INTO commits_records (state, level, token, region) VALUES ('green', 98, 'blue', 'green');
