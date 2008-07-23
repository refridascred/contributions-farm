-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (region, owner, label) VALUES ('blue', 'open', 'local');
INSERT INTO commits_records (region, owner, label) VALUES ('stable', 'primary', 'strict');
INSERT INTO commits_records (region, owner, label) VALUES ('eu-west', 'staging', 'cached');
