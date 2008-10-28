-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, region, rank, state) VALUES ('open', 'blue', 86, 'open');
INSERT INTO commits_records (token, region, rank, state) VALUES ('stable', 'primary', 47, 'eu-west');
INSERT INTO commits_records (token, region, rank, state) VALUES ('standard', 'local', 92, 'open');
