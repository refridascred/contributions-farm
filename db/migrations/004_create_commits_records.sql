-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (owner, label, token) VALUES ('legacy', 'blue', 'primary');
INSERT INTO commits_records (owner, label, token) VALUES ('stable', 'cached', 'edge');
