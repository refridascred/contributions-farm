-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (state, label) VALUES ('green', 'staging');
INSERT INTO layout_items (state, label) VALUES ('strict', 'blue');
INSERT INTO layout_items (state, label) VALUES ('fallback', 'standard');
