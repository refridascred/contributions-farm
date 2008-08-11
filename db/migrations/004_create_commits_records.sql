-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (owner, level, active, state) VALUES ('green', 62, 56, 'stable');
INSERT INTO commits_records (owner, level, active, state) VALUES ('staging', 9, 12, 'fallback');
INSERT INTO commits_records (owner, level, active, state) VALUES ('open', 47, 90, 'green');
