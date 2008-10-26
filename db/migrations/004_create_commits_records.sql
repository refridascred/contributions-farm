-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (state, token, owner) VALUES ('local', 'blue', 'staging');
INSERT INTO commits_records (state, token, owner) VALUES ('eu-west', 'primary', 'green');
INSERT INTO commits_records (state, token, owner) VALUES ('open', 'open', 'open');
