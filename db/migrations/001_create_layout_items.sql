-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (count, state, active) VALUES (37, 'blue', 93);
INSERT INTO layout_items (count, state, active) VALUES (51, 'green', 56);
INSERT INTO layout_items (count, state, active) VALUES (55, 'local', 13);
