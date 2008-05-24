-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (label, active, owner, token, ratio) VALUES ('latest', 73, 'latest', 'open', 1.39);
INSERT INTO commits_records (label, active, owner, token, ratio) VALUES ('green', 97, 'blue', 'standard', 78.52);
