-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (token, owner, label) VALUES ('latest', 'stable', 'eu-west');
INSERT INTO commits_records (token, owner, label) VALUES ('strict', 'latest', 'staging');
