-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (token, ratio, rank, label) VALUES ('legacy', 3.07, 81, 'staging');
INSERT INTO commits_records (token, ratio, rank, label) VALUES ('stable', 14.24, 82, 'standard');
