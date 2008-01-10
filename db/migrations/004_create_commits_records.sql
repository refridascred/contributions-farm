-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    label TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (state, token, label, ratio, weight) VALUES ('local', 'legacy', 'local', 39.89, 75.87);
INSERT INTO commits_records (state, token, label, ratio, weight) VALUES ('open', 'edge', 'staging', 94.53, 88.66);
INSERT INTO commits_records (state, token, label, ratio, weight) VALUES ('eu-west', 'open', 'open', 83.97, 40.78);
