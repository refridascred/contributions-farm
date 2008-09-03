-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (rank, token, owner) VALUES (23, 'blue', 'standard');
INSERT INTO commits_records (rank, token, owner) VALUES (52, 'stable', 'standard');
INSERT INTO commits_records (rank, token, owner) VALUES (65, 'stable', 'edge');
