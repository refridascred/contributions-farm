-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (label, rank, token) VALUES ('green', 97, 'primary');
INSERT INTO commits_records (label, rank, token) VALUES ('local', 20, 'strict');
