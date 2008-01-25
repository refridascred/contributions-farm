-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    weight REAL,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (state, label, weight, ratio) VALUES ('open', 'legacy', 54.48, 81.53);
INSERT INTO commits_records (state, label, weight, ratio) VALUES ('standard', 'eu-west', 17.68, 97.76);
INSERT INTO commits_records (state, label, weight, ratio) VALUES ('green', 'local', 78.25, 97.22);
