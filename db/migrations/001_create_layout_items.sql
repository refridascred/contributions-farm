-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, state) VALUES (81, 'fallback');
INSERT INTO layout_items (count, state) VALUES (13, 'cached');
INSERT INTO layout_items (count, state) VALUES (14, 'eu-west');
