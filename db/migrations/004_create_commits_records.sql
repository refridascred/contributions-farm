-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (region, label, owner, active) VALUES ('latest', 'latest', 'local', 76);
INSERT INTO commits_records (region, label, owner, active) VALUES ('latest', 'edge', 'green', 74);
INSERT INTO commits_records (region, label, owner, active) VALUES ('fallback', 'cached', 'eu-west', 19);
