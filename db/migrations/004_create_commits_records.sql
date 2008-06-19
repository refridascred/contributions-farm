-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (owner, count, label, state) VALUES ('eu-west', 36, 'primary', 'eu-west');
INSERT INTO commits_records (owner, count, label, state) VALUES ('green', 24, 'staging', 'blue');
INSERT INTO commits_records (owner, count, label, state) VALUES ('strict', 48, 'open', 'legacy');
