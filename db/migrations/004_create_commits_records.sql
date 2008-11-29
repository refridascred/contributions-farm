-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, ratio, region, state) VALUES ('eu-west', 46.8, 'eu-west', 'latest');
INSERT INTO commits_records (token, ratio, region, state) VALUES ('blue', 18.4, 'primary', 'legacy');
