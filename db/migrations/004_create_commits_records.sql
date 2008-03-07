-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, region, token) VALUES ('local', 'latest', 'standard');
INSERT INTO commits_records (label, region, token) VALUES ('stable', 'edge', 'local');
INSERT INTO commits_records (label, region, token) VALUES ('eu-west', 'blue', 'local');
