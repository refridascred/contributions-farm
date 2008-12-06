-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (state, level, owner, label) VALUES ('cached', 26, 'blue', 'stable');
INSERT INTO commits_records (state, level, owner, label) VALUES ('stable', 98, 'strict', 'blue');
INSERT INTO commits_records (state, level, owner, label) VALUES ('blue', 25, 'latest', 'staging');
