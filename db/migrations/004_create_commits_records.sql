-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (state, token, level, ratio) VALUES ('staging', 'blue', 40, 83.7);
INSERT INTO commits_records (state, token, level, ratio) VALUES ('open', 'legacy', 9, 36.12);
