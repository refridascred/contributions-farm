-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (label, owner, state, score) VALUES ('edge', 'local', 'legacy', 16.23);
INSERT INTO layout_items (label, owner, state, score) VALUES ('eu-west', 'staging', 'eu-west', 98.76);
