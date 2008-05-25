-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (owner, rank, active, label) VALUES ('strict', 14, 71, 'cached');
INSERT INTO commits_records (owner, rank, active, label) VALUES ('blue', 8, 69, 'local');
INSERT INTO commits_records (owner, rank, active, label) VALUES ('strict', 60, 82, 'latest');
