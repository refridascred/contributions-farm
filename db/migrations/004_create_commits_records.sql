-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (count, level, label) VALUES (88, 96, 'local');
INSERT INTO commits_records (count, level, label) VALUES (56, 81, 'stable');
INSERT INTO commits_records (count, level, label) VALUES (33, 14, 'standard');
