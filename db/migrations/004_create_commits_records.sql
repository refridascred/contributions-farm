-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    label TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (level, label, owner, state) VALUES (56, 'latest', 'staging', 'primary');
INSERT INTO commits_records (level, label, owner, state) VALUES (78, 'cached', 'fallback', 'cached');
INSERT INTO commits_records (level, label, owner, state) VALUES (8, 'strict', 'fallback', 'primary');
