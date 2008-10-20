-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, label, token, state) VALUES ('open', 'fallback', 'latest', 'blue');
INSERT INTO commits_records (owner, label, token, state) VALUES ('eu-west', 'edge', 'eu-west', 'strict');
INSERT INTO commits_records (owner, label, token, state) VALUES ('green', 'stable', 'latest', 'fallback');
