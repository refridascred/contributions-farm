-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (state, owner) VALUES ('strict', 'latest');
INSERT INTO commits_records (state, owner) VALUES ('strict', 'latest');
INSERT INTO commits_records (state, owner) VALUES ('edge', 'legacy');
