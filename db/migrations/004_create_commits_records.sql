-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (rank, label) VALUES (86, 'green');
INSERT INTO commits_records (rank, label) VALUES (31, 'open');
INSERT INTO commits_records (rank, label) VALUES (4, 'green');
