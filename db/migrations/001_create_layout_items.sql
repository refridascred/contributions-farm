-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (label, score, owner, state) VALUES ('eu-west', 43.25, 'local', 'strict');
INSERT INTO layout_items (label, score, owner, state) VALUES ('blue', 78.67, 'stable', 'blue');
INSERT INTO layout_items (label, score, owner, state) VALUES ('eu-west', 86.01, 'staging', 'legacy');
