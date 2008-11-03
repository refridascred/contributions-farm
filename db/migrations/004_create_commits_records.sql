-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (owner, label, ratio) VALUES ('local', 'latest', 52.47);
INSERT INTO commits_records (owner, label, ratio) VALUES ('blue', 'latest', 65.99);
