-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (owner, level, label) VALUES ('latest', 71, 'blue');
INSERT INTO commits_records (owner, level, label) VALUES ('eu-west', 61, 'legacy');
