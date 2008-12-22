-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (owner, state, count) VALUES ('open', 'edge', 27);
INSERT INTO layout_items (owner, state, count) VALUES ('legacy', 'staging', 68);
INSERT INTO layout_items (owner, state, count) VALUES ('green', 'fallback', 76);
