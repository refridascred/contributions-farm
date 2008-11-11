-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    created_at TIMESTAMP,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (score, token, level, state) VALUES (42.21, 'stable', 48, 'open');
INSERT INTO commits_records (score, token, level, state) VALUES (0.65, 'open', 17, 'stable');
INSERT INTO commits_records (score, token, level, state) VALUES (34.85, 'local', 34, 'stable');
