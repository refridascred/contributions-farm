-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (label, owner, state, count) VALUES ('blue', 'blue', 'standard', 0);
INSERT INTO layout_items (label, owner, state, count) VALUES ('latest', 'staging', 'legacy', 29);
INSERT INTO layout_items (label, owner, state, count) VALUES ('standard', 'edge', 'cached', 42);
