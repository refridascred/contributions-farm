-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, rank, region) VALUES ('standard', 19, 'standard');
INSERT INTO commits_records (label, rank, region) VALUES ('cached', 9, 'standard');
INSERT INTO commits_records (label, rank, region) VALUES ('open', 96, 'green');
