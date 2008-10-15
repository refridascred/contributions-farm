-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, weight, owner) VALUES ('eu-west', 27.76, 'staging');
INSERT INTO commits_records (label, weight, owner) VALUES ('cached', 21.12, 'edge');
