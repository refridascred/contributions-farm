-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, token, region, count, state) VALUES ('green', 'fallback', 'staging', 5, 'local');
INSERT INTO commits_records (label, token, region, count, state) VALUES ('green', 'green', 'eu-west', 40, 'green');
INSERT INTO commits_records (label, token, region, count, state) VALUES ('latest', 'green', 'local', 21, 'stable');
