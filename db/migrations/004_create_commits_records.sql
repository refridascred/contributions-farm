-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (token, count, label) VALUES ('latest', 98, 'cached');
INSERT INTO commits_records (token, count, label) VALUES ('open', 40, 'latest');
INSERT INTO commits_records (token, count, label) VALUES ('primary', 79, 'latest');
