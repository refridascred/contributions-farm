-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (rank, token, owner) VALUES (93, 'eu-west', 'legacy');
INSERT INTO commits_records (rank, token, owner) VALUES (21, 'standard', 'local');
INSERT INTO commits_records (rank, token, owner) VALUES (90, 'blue', 'green');
