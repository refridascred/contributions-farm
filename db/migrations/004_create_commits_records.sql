-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (ratio, region, state) VALUES (21.7, 'standard', 'green');
INSERT INTO commits_records (ratio, region, state) VALUES (74.49, 'cached', 'eu-west');
INSERT INTO commits_records (ratio, region, state) VALUES (14.09, 'primary', 'open');
