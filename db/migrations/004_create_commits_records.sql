-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (state, owner, weight) VALUES ('open', 'fallback', 22.28);
INSERT INTO commits_records (state, owner, weight) VALUES ('edge', 'cached', 62.89);
INSERT INTO commits_records (state, owner, weight) VALUES ('green', 'edge', 75.41);
