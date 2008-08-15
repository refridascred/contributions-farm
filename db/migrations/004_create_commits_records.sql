-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, weight, owner, token) VALUES ('green', 46.6, 'cached', 'strict');
INSERT INTO commits_records (label, weight, owner, token) VALUES ('cached', 47.87, 'strict', 'latest');
