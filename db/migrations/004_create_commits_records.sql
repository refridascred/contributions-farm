-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, owner, ratio) VALUES ('cached', 'local', 68.23);
INSERT INTO commits_records (token, owner, ratio) VALUES ('blue', 'fallback', 75.77);
INSERT INTO commits_records (token, owner, ratio) VALUES ('blue', 'edge', 43.35);
