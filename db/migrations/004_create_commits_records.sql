-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (token, label, region) VALUES ('open', 'local', 'fallback');
INSERT INTO commits_records (token, label, region) VALUES ('open', 'edge', 'green');
