-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (weight, label, state) VALUES (88.2, 'cached', 'fallback');
INSERT INTO layout_items (weight, label, state) VALUES (45.02, 'latest', 'eu-west');
