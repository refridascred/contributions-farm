-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (level, state, owner, token) VALUES (17, 'standard', 'stable', 'open');
INSERT INTO commits_records (level, state, owner, token) VALUES (1, 'eu-west', 'local', 'primary');
INSERT INTO commits_records (level, state, owner, token) VALUES (32, 'fallback', 'local', 'fallback');
