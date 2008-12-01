-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (owner, ratio, label) VALUES ('fallback', 7.75, 'edge');
INSERT INTO commits_records (owner, ratio, label) VALUES ('standard', 14.15, 'standard');
INSERT INTO commits_records (owner, ratio, label) VALUES ('strict', 78.12, 'latest');
