-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, owner) VALUES ('fallback', 'latest');
INSERT INTO layout_items (state, owner) VALUES ('legacy', 'open');
INSERT INTO layout_items (state, owner) VALUES ('stable', 'staging');
