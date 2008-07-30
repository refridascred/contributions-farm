-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (state, region, label) VALUES ('local', 'eu-west', 'latest');
INSERT INTO commits_records (state, region, label) VALUES ('latest', 'blue', 'local');
