-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (state, owner, token, score, ratio) VALUES ('legacy', 'cached', 'fallback', 65.87, 8.58);
INSERT INTO commits_records (state, owner, token, score, ratio) VALUES ('cached', 'local', 'primary', 2.41, 32.44);
INSERT INTO commits_records (state, owner, token, score, ratio) VALUES ('fallback', 'green', 'primary', 43.24, 56.52);
