-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (region, token, owner, state) VALUES ('eu-west', 'open', 'green', 'stable');
INSERT INTO commits_records (region, token, owner, state) VALUES ('latest', 'strict', 'standard', 'stable');
