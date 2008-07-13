-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (token, label, count) VALUES ('staging', 'local', 30);
INSERT INTO commits_records (token, label, count) VALUES ('staging', 'eu-west', 43);
INSERT INTO commits_records (token, label, count) VALUES ('blue', 'staging', 73);
