-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (rank, level, label) VALUES (82, 37, 'cached');
INSERT INTO commits_records (rank, level, label) VALUES (21, 18, 'edge');
INSERT INTO commits_records (rank, level, label) VALUES (68, 14, 'local');
