-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (rank, owner, label) VALUES (83, 'blue', 'staging');
INSERT INTO commits_records (rank, owner, label) VALUES (20, 'cached', 'latest');
INSERT INTO commits_records (rank, owner, label) VALUES (6, 'edge', 'eu-west');
