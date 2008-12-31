-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (score, owner, state) VALUES (3.31, 'latest', 'open');
INSERT INTO layout_items (score, owner, state) VALUES (67.09, 'open', 'eu-west');
INSERT INTO layout_items (score, owner, state) VALUES (74.68, 'local', 'fallback');
