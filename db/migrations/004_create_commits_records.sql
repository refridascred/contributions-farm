-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (score, label, owner, state) VALUES (18.2, 'staging', 'legacy', 'fallback');
INSERT INTO commits_records (score, label, owner, state) VALUES (20.33, 'primary', 'open', 'staging');
