-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (owner, label, region) VALUES ('eu-west', 'green', 'primary');
INSERT INTO commits_records (owner, label, region) VALUES ('local', 'eu-west', 'standard');
