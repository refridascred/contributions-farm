-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    label TEXT,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (token, level, label, owner, rank) VALUES ('stable', 69, 'green', 'staging', 59);
INSERT INTO commits_records (token, level, label, owner, rank) VALUES ('fallback', 84, 'eu-west', 'blue', 56);
