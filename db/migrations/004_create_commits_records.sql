-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (region, token, state) VALUES ('stable', 'primary', 'latest');
INSERT INTO commits_records (region, token, state) VALUES ('edge', 'green', 'local');
INSERT INTO commits_records (region, token, state) VALUES ('open', 'local', 'staging');
