-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (rank, label) VALUES (9, 'local');
INSERT INTO commits_records (rank, label) VALUES (95, 'legacy');
INSERT INTO commits_records (rank, label) VALUES (70, 'stable');
