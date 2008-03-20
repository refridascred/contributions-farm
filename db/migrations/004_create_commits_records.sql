-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (region, rank, label, state) VALUES ('latest', 89, 'staging', 'green');
INSERT INTO commits_records (region, rank, label, state) VALUES ('green', 1, 'legacy', 'blue');
INSERT INTO commits_records (region, rank, label, state) VALUES ('standard', 31, 'blue', 'stable');
