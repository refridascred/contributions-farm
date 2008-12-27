-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, owner, state) VALUES ('green', 'latest', 'green');
INSERT INTO commits_records (region, owner, state) VALUES ('local', 'cached', 'green');
INSERT INTO commits_records (region, owner, state) VALUES ('staging', 'blue', 'eu-west');
