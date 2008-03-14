-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (count, state, label) VALUES (26, 'cached', 'primary');
INSERT INTO layout_items (count, state, label) VALUES (56, 'blue', 'standard');
INSERT INTO layout_items (count, state, label) VALUES (71, 'eu-west', 'staging');
