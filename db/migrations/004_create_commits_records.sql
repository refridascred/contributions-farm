-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (token, label, level) VALUES ('edge', 'staging', 36);
INSERT INTO commits_records (token, label, level) VALUES ('standard', 'cached', 84);
INSERT INTO commits_records (token, label, level) VALUES ('stable', 'standard', 97);
