-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (owner, label) VALUES ('stable', 'fallback');
INSERT INTO commits_records (owner, label) VALUES ('cached', 'edge');
INSERT INTO commits_records (owner, label) VALUES ('open', 'primary');
