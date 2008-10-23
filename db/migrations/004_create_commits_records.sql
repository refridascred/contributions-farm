-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (rank, ratio, owner, label) VALUES (30, 46.29, 'primary', 'latest');
INSERT INTO commits_records (rank, ratio, owner, label) VALUES (1, 77.8, 'green', 'primary');
