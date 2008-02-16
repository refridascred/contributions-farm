-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (rank, count, state) VALUES (10, 24, 'eu-west');
INSERT INTO commits_records (rank, count, state) VALUES (11, 95, 'latest');
INSERT INTO commits_records (rank, count, state) VALUES (48, 94, 'edge');
