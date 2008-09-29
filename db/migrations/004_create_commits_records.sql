-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);
