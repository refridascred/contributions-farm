-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (owner, state, ratio) VALUES ('local', 'primary', 46.94);
INSERT INTO commits_records (owner, state, ratio) VALUES ('primary', 'edge', 93.06);
INSERT INTO commits_records (owner, state, ratio) VALUES ('primary', 'primary', 14.41);
