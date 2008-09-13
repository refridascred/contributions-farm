-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (state, label, level) VALUES ('blue', 'standard', 1);
INSERT INTO commits_records (state, label, level) VALUES ('latest', 'edge', 76);
INSERT INTO commits_records (state, label, level) VALUES ('blue', 'staging', 58);
