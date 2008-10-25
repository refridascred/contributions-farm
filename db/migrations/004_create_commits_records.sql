-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (state, region, owner, token) VALUES ('eu-west', 'eu-west', 'standard', 'local');
INSERT INTO commits_records (state, region, owner, token) VALUES ('strict', 'cached', 'open', 'stable');
INSERT INTO commits_records (state, region, owner, token) VALUES ('blue', 'stable', 'blue', 'strict');
