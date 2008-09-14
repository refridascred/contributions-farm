-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (region, token) VALUES ('edge', 'stable');
INSERT INTO commits_records (region, token) VALUES ('standard', 'primary');
INSERT INTO commits_records (region, token) VALUES ('legacy', 'primary');
