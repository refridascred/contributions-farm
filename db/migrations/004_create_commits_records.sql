-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, active, rank, label) VALUES ('eu-west', 99, 79, 'local');
INSERT INTO commits_records (token, active, rank, label) VALUES ('open', 36, 99, 'primary');
INSERT INTO commits_records (token, active, rank, label) VALUES ('stable', 26, 37, 'latest');
