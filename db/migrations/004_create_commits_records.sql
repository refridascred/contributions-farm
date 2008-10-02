-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    owner TEXT NOT NULL,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (weight, token, owner, label) VALUES (74.77, 'cached', 'green', 'stable');
INSERT INTO commits_records (weight, token, owner, label) VALUES (97.44, 'eu-west', 'legacy', 'standard');
INSERT INTO commits_records (weight, token, owner, label) VALUES (60.55, 'strict', 'eu-west', 'standard');
