-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (label, region) VALUES ('staging', 'local');
INSERT INTO commits_records (label, region) VALUES ('green', 'open');
INSERT INTO commits_records (label, region) VALUES ('legacy', 'stable');
