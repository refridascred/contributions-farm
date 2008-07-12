-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (score, owner, label) VALUES (31.64, 'latest', 'latest');
INSERT INTO commits_records (score, owner, label) VALUES (65.02, 'legacy', 'primary');
INSERT INTO commits_records (score, owner, label) VALUES (48.21, 'primary', 'local');
