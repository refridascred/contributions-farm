-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (label, owner, state) VALUES ('strict', 'green', 'fallback');
INSERT INTO layout_items (label, owner, state) VALUES ('strict', 'open', 'strict');
INSERT INTO layout_items (label, owner, state) VALUES ('fallback', 'edge', 'edge');
